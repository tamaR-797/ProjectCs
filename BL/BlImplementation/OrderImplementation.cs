using BL.BlApi;
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.BlImplementation;

internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public int DoOrder(Order order)
    {
        if (order == null) throw new Exception("Order cannot be null");
        if (order.Items == null || !order.Items.Any()) throw new Exception("Cannot place an empty order.");

        // בדיקת מלאי וקיום מוצרים מול ה-DAL
        foreach (var item in order.Items)
        {
            var doProduct = _dal.Product.Read(item.ProductId);
            if (doProduct == null) throw new Exception($"Product {item.ProductId} not found");

            if ((doProduct.QuantityInStock ?? 0) < item.Quantity)
            {
                throw new Exception($"Out of stock for product: {doProduct.ProdName}");
            }
        }

        var customer = _dal.Customer.Read(order.CustomerId);
        if (customer == null) throw new Exception($"Customer {order.CustomerId} not found");

        double totalOrderPrice = 0;
        foreach (var item in order.Items)
        {
            // שליחת false כברירת מחדל לחבר מועדון, או שימוש בנתון האמיתי מהלקוח (למשל customer.IsClub)
            double itemTotalPrice = CalculateItemPrice(item.ProductId, item.Quantity, false);
            item.PricePerUnit = itemTotalPrice / item.Quantity;
            totalOrderPrice += itemTotalPrice;
        }

        order.TotalPrice = totalOrderPrice;
        order.OrderDate = DateTime.Now;

        // 1. יצירת ההזמנה הראשית ב-DAL (שימוש מפורש ב-DO.Order)
        int newOrderId = _dal.Order.Create(new DO.Order
        {
            CustId = order.CustomerId,
            OrderDate = order.OrderDate,
            ShipDate = null,
            DeliveryDate = null
        });

        // 2. יצירת פריטי ההזמנה ב-DAL ועדכון המלאי
        foreach (var item in order.Items)
        {
            _dal.OrderItem.Create(new DO.OrderItem
            {
                OrderId = newOrderId,
                ProdId = item.ProductId,
                QuantityItem = item.Quantity,
                PriceItem = item.PricePerUnit
            });

            // עדכון המלאי בקובץ הנתונים
            var doProduct = _dal.Product.Read(item.ProductId);
            if (doProduct != null)
            {
                _dal.Product.Update(doProduct with { QuantityInStock = (doProduct.QuantityInStock ?? 0) - item.Quantity });
            }
        }

        return newOrderId;
    }

    public double CalculateItemPrice(int productId, int quantity, bool isClubMember)
    {
        var doProduct = _dal.Product.Read(productId);
        if (doProduct == null) return 0;

        double basePrice = (doProduct.ProdPrice ?? 0) * quantity;

        // חישוב המבצעים הפעילים מה-DAL
        var activeSale = (from s in _dal.Sale.ReadAll()
                          where s != null &&
                                s.ProdId == productId &&
                                s.StartDate <= DateTime.Now &&
                                s.EndDate >= DateTime.Now &&
                                (!s.IsClub || isClubMember) &&
                                quantity >= (s.QuantitySale ?? 0)
                          select s).FirstOrDefault();

        return activeSale != null ? (activeSale.SalePrice ?? 0) * quantity : basePrice;
    }

    public double GetTotalOrderSum(List<OrderItem> items, bool isClubMember)
    {
        return items.Sum(item => CalculateItemPrice(item.ProductId, item.Quantity, isClubMember));
    }

    public bool IsStockAvailable(List<OrderItem> items)
    {
        return items.All(item => {
            var p = _dal.Product.Read(item.ProductId);
            return p != null && (p.QuantityInStock ?? 0) >= item.Quantity;
        });
    }

    public List<Order> ReadAllOrders(Func<Order, bool>? filter = null) => throw new NotImplementedException();
    public Order? GetOrderDetails(int orderId) => throw new NotImplementedException();
}
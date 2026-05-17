using BlApi; // הממשקים של ה-BL
using BO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL.BlImplementation;

internal class CartImplementation : ICart
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public Cart AddProductToCart(Cart cart, int productId)
    {
        if (cart == null) throw new ArgumentNullException(nameof(cart));

        // שליפת המוצר מה-DAL (ישויות DO)
        DO.Product p = _dal.Product.Read(productId) ?? throw new Exception("Product not found");

        if (p.QuantityInStock <= 0) throw new Exception("Out of stock");

        cart.Items ??= new List<ItemInCart>();
        var itemsList = cart.Items.ToList();
        var item = itemsList.FirstOrDefault(i => i.ProdId == productId);

        if (item != null)
        {
            item.Quantity++;
            item.TotalPrice = item.Quantity * item.Price;
        }
        else
        {
            itemsList.Add(new ItemInCart
            {
                ProdId = productId,
                ProdName = p.ProdName,
                Price = p.ProdPrice ?? 0,
                Quantity = 1,
                TotalPrice = p.ProdPrice ?? 0
            });
        }

        cart.Items = itemsList;
        cart.FinalPrice = cart.Items.Sum(i => i.TotalPrice);
        return cart;
    }

    public Cart UpdateQuantity(Cart cart, int productId, int newQuantity)
    {
        if (cart == null) throw new ArgumentNullException(nameof(cart));
        if (cart.Items == null) return cart;

        var itemsList = cart.Items.ToList();
        var item = itemsList.FirstOrDefault(i => i.ProdId == productId);

        if (item != null)
        {
            if (newQuantity <= 0)
            {
                itemsList.Remove(item);
            }
            else
            {
                DO.Product p = _dal.Product.Read(productId) ?? throw new Exception("Product not found");
                if (p.QuantityInStock < newQuantity) throw new Exception("Not enough stock");

                item.Quantity = newQuantity;
                item.TotalPrice = item.Quantity * item.Price;
            }

            cart.Items = itemsList;
            cart.FinalPrice = cart.Items.Sum(i => i.TotalPrice);
        }

        return cart;
    }

    public void ConfirmOrder(Cart cart)
    {
        if (cart == null) throw new ArgumentNullException(nameof(cart));
        if (cart.Items == null || !cart.Items.Any()) throw new Exception("Cart is empty");

        foreach (var item in cart.Items)
        {
            var p = _dal.Product.Read(item.ProdId);
            if (p == null) throw new Exception($"Product {item.ProdId} not found");
            if (p.QuantityInStock < item.Quantity)
                throw new Exception($"Not enough stock for {item.ProdName}");
        }

        // יצירת אובייקט הזמנה לוגי ושליחתו למימוש של ה-Order
        Order newOrder = new Order
        {
            CustomerId = 1, // זמני לפי דרישות הבדיקה
            Items = cart.Items.Select(i => new OrderItem
            {
                ProductId = i.ProdId,
                Quantity = i.Quantity
            }).ToList()
        };

        // קריאה ישירה למימוש ה-Order בשביל לבצע את ההזמנה בפועל ב-DAL ולעדכן מלאי
        BL.BlApi.IOrder orderLogic = new OrderImplementation();
        orderLogic.DoOrder(newOrder);
    }
}
using BO;
using System.Linq;

namespace BlImplementation;

internal class SaleImplementation : BlApi.ISale
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public IEnumerable<BO.SaleForList> GetSalesList()
    {
        return from DO.Order doOrd in _dal.Order.ReadAll()
               let orderItems = _dal.OrderItem.ReadAll(oi => oi?.OrderId == doOrd.Id)
               select new BO.SaleForList
               {
                   OrderId = doOrd.OrderId,
                   CustomerName = _dal.Customer.Read(doOrd.CustomerId)?.CustName ?? "Unknown",
                   AmountOfItems = orderItems.Count(),
                   TotalPrice = orderItems.Sum(oi => (oi?.PricePerUnit ?? 0) * (oi?.Quantity ?? 0))
               };
    }

    public BO.Sale GetSaleDetails(int id) => throw new NotImplementedException();
    public BO.Sale UpdateOrderShipping(int id) => throw new NotImplementedException();
    public BO.Sale UpdateOrderDelivery(int id) => throw new NotImplementedException();

    // מימושים ריקים עבור שאר פונקציות הממשק
    public IEnumerable<Sale?> GetAllSales() => throw new NotImplementedException();
    public void AddSale(Sale sale) => throw new NotImplementedException();
    public void UpdateSale(Sale sale) => throw new NotImplementedException();
    public void DeleteSale(int id) => throw new NotImplementedException();
    public IEnumerable<Sale?> GetActiveSalesByProduct(int productId) => throw new NotImplementedException();
}
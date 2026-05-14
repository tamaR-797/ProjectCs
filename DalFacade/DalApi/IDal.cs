

namespace DalApi;
public interface IDal
{
    ICustomer Customer { get; }
    IProduct Product { get; }
    ISale Sale { get; }
    IOrder Order { get; }      // הוספה
    IOrderItem OrderItem { get; } // הוספה
}
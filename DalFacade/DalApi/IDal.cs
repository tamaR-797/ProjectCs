

using DO;

namespace DalApi
{
    public  interface IDal
    {
        IOrder Order { get; }
        IOrderItem OrderItem { get; }
        ICustomer Customer { get; }
        IProduct Product { get; }
        ISale Sale { get; }

    }
}

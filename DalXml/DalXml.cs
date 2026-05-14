using DalApi;
using DO;

namespace Dal;

 internal sealed class DalXml : IDal
{
    private static readonly Lazy<DalXml> _instance = new Lazy<DalXml>(() => new DalXml());
    public static DalXml Instance => _instance.Value;
    private DalXml() { }

    public ICustomer Customer => new CustomerImplementation();
    public IProduct Product => new ProductImplementation();
    public ISale Sale => new SaleImplementation();
    public IOrder Order => new OrderImplementaion(); // הוספה
    public IOrderItem OrderItem => new OrderItemImplementaion(); // הוספה
}
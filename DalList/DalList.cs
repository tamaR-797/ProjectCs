using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dal;

    internal sealed class DalList:IDal
    {
    private DalList() {
    }
    private static readonly DalList instance = new DalList();
    public  static DalList Instance => instance;

    // מימושים של המאפיינים מהממשק IDal
    public IOrder Order => new OrderImplementation(); 
    public IOrderItem OrderItem => new OrderItemImplementation();
    public ISale Sale => new SaleImplementation();
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();

}


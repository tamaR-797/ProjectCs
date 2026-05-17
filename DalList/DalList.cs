using DalApi;

using DalList;

namespace Dal;

    internal sealed class DalList:IDal
    {
    private DalList() {
    }
    private static readonly DalList instance = new DalList();
    public static DalList Instance => instance;
    public ISale Sale => new SaleImplementation();
        public IProduct Product => new ProductImplementation();
        public ICustomer Customer => new CustomerImplementation();

    }


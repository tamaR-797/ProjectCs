using BlApi;


namespace BlImplementation
{
    internal class BL : IBl
    {
        public ISale ISale => new SaleImplementation();

        public IProduct IProduct => new ProductImplementation();

        public IClient IClient => new ClientImplementation();

        public IOrder IOrder => new OrderImplementation();

    }
}

using BlApi;

namespace BlImplementation;

internal sealed class Bl : IBl
{
    private static readonly Lazy<Bl> _instance = new(() => new Bl());
    public static IBl Instance => _instance.Value;

    private Bl() { }

    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();
    public ICart Cart => new CartImplementation();
}
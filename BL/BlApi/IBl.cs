namespace BlApi;

public interface IBl
{
    public IProduct Product { get; }
    public ICustomer Customer { get; }
    public ISale Sale { get; }
    public ICart Cart { get; }
}
using DO;

namespace Dal;
internal static class DataSource
{

    internal static List<Sale> sales = new List<Sale>();
    internal static List<Customer> customers = new List<Customer>();
    internal static List<Product> products = new List<Product>();
    
}

static internal class ProductConfig
{
    internal const int start = 1001; // product ids can start from a different base

    private static int current = start;

    public static int Next
    {
        get { return current++; }
    }
}

static internal class SaleConfig
{
    internal const int start = 100; // sale ids start from 100

    private static int current = start;

    public static int Next
    {
        get { return current++; }
    }
}


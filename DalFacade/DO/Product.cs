
using System.Runtime.CompilerServices;

namespace DO
{
    public record Product(int ProdId, string? ProdName=null, Categories? Category=null, double? ProdPrice=null, int? QuantityInStock = null)
    {
        public Product() : this(0)
        {
        }
    }

}

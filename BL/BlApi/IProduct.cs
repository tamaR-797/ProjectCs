using BO;

namespace BlApi;

public interface IProduct
{
    public IEnumerable<Product?> GetAllProducts();
    public Product GetProductDetails(int id);
    public void AddProduct(Product product);
    public void UpdateProduct(Product product);
    public void DeleteProduct(int id);
}
namespace BlImplementation;

internal class ProductImplementation : BlApi.IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public IEnumerable<BO.Product?> GetAllProducts()
    {
        return from DO.Product doProd in _dal.Product.ReadAll()
               select new BO.Product
               {
                   ProdId = doProd.ProdId,
                   ProdName = doProd.ProdName,
                   ProdPrice = doProd.ProdPrice ?? 0,
                   InStock = doProd.QuantityInStock ?? 0,
                   Category = (BO.Categories)doProd.Category!
               };
    }

    public BO.Product GetProductDetails(int id)
    {
        try
        {
            DO.Product doProd = _dal.Product.Read(id)!;
            return new BO.Product
            {
                ProdId = doProd.ProdId,
                ProdName = doProd.ProdName,
                ProdPrice = doProd.ProdPrice ?? 0,
                InStock = doProd.QuantityInStock ?? 0,
                Category = (BO.Categories)doProd.Category!
            };
        }
        catch (DO.DalDoesNotExistException ex)
        {
            throw new Exception($"Product {id} not found", ex);
        }
    }

    public void AddProduct(BO.Product boProd)
    {
        if (boProd.ProdPrice <= 0 || boProd.InStock < 0) throw new Exception("Invalid values");
        try
        {
            _dal.Product.Create(new DO.Product(boProd.ProdId, boProd.ProdName, (DO.Categories)boProd.Category, boProd.ProdPrice, boProd.InStock));
        }
        catch (DO.DalAlreadyExistsException ex) { throw new Exception("Product exists", ex); }
    }

    public void UpdateProduct(BO.Product boProd) => throw new NotImplementedException();
    public void DeleteProduct(int id) => throw new NotImplementedException();
}
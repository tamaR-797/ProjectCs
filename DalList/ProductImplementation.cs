
using DO;
using DalApi;
using System.Reflection;
using Tools;
using static Dal.DataSource;



namespace Dal;

public class ProductImplementation : IProduct
{


    public Product Read(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read with: " + id);
        var q = from p in products
                where p.id == id
                select p;

        if (q.FirstOrDefault() == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read failed: " + id + " does not exist");
            throw new DalDoesNotExistException($"Product with ID {id} does not exist.");
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "read successfully");
        return q.FirstOrDefault();
    }

    public int Create(Product product)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called create with: " + product);
        if (products.Any(p => p.id == product.id))
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called create failed: product already exists");
            throw new DalAlreadyExistsException($"Product with ID {product.id} already exists.");
        }
        int idRun = ProductConfig.Next;
        product = product with { id = idRun };
        products.Add(product);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "created successfully");
        return idRun;
    }

    public void Delete(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called delete with id: " + id);

        var q = from p in products
                where p.id == id
                select p;

        Product? p1 = q.FirstOrDefault();
        if (p1 == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called delete failed: " + id + " does not exist");
            throw new DalDoesNotExistException($"Product with ID {id} does not exist and cannot be deleted.");
        }

        products.Remove(p1);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "deleted successfully");
    }

    public void Update(Product product)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called update with: " + product);
        Delete(product.id);
        products.Add(product);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "updated successfully");
    }

    List<Product> ICrud<Product>.ReadAll(Func<Product, bool>? filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read all with filter: " + (filter != null ? filter.ToString() : "null"));

        List<Product> list = new List<Product>();

        if (filter != null)
        {
            list = products.Where(p => filter(p)).ToList();
        }
        else
        {
            list = products.ToList();
        }

        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "read all successfully, found " + list.Count() + " products");
        return list;
    }

    Product ICrud<Product>.Read(Func<Product, bool> filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read by filter");
        Product result = products.FirstOrDefault(p => filter(p));
        if (result == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read failed: product with filter does not exist");
            throw new DalDoesNotExistException("Product with filter does not exist.");
        }
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "read by filter successfully");
        return result;
    }
}

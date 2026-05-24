

using DalApi;
using DO;
using System;
using System.Reflection;
using Tools;
using static Dal.DataSource;



namespace Dal;


public class SaleImplementation : ISale
{

    public Sale Read(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read by id with: " + id);
        var q = from s in sales
                where s.id == id
                select s;

        if (q.FirstOrDefault() == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, " id accepted not exist");
            throw new DalDoesNotExistException($"Sale with ID {id} does not exist.");
        }
        else
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, " end read call found sale");
            return q.FirstOrDefault();
        }

    }

    public int Create(Sale sale)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, " called create with " + sale);
        int idRun = SaleConfig.Next;
        sale = sale with { id = idRun };
        sales.Add(sale);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "created seccsesfully");
        return idRun;

    }

    public void Delete(int id)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called delete with id : " + id);

        var q = from s in sales
                where s.id == id
                select s;

        Sale? s1 = q.FirstOrDefault();
        if (s1 == null)
        {
            LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "exception no id was found to delete");
            throw new DalDoesNotExistException($"Sale with ID {id} does not exist and cannot be deleted.");
        }

        sales.Remove(s1);
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "deleted seccesfully");
    }

    public void Update(Sale sale)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called update ");
        Delete(sale.id);

        sales.Add(sale);

    }

    List<Sale> ICrud<Sale>.ReadAll(Func<Sale, bool>? filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read all with filter: " + filter);

        List<Sale> list = new List<Sale>();

        if (filter != null)
        {
            list = sales.Where(s => filter(s)).ToList();
        }
        else
        {
            list = sales.ToList();

        }

        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "end read all call found " + list.Count() + " sales");
        return list;
    }

    Sale ICrud<Sale>.Read(Func<Sale, bool> filter)
    {
        LogManager.WriteLog(MethodBase.GetCurrentMethod().Name, MethodBase.GetCurrentMethod().DeclaringType.FullName, "called read with filter: " + filter);
        return sales.FirstOrDefault(s => filter(s));

    }
}

using BO;
using System.Linq;

namespace BlImplementation;

internal class CustomerImplementation : BlApi.ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public IEnumerable<BO.Customer?> GetAllCustomers()
    {
        return _dal.Customer.ReadAll().Select(doCust => new BO.Customer
        {
            CustId = doCust!.CustId,
            CustName = doCust.CustName,
            CustAddress = doCust.CustAddress,
            CustPhone = doCust.CustPhone
        });
    }

    public BO.Customer GetCustomerDetails(int id)
    {
        try
        {
            var doCust = _dal.Customer.Read(id)!;
            return new BO.Customer { CustId = doCust.CustId, CustName = doCust.CustName, CustAddress = doCust.CustAddress, CustPhone = doCust.CustPhone };
        }
        catch (DalApi.DalDoesNotExistException ex) { throw new Exception("Customer missing", ex); }
    }

    public void AddCustomer(BO.Customer boCust)
    {
        try { _dal.Customer.Create(new DO.Customer(boCust.CustId, boCust.CustName, boCust.CustAddress, boCust.CustPhone)); }
        catch (DalApi.DalDoesNotExistException ex) { throw new Exception("Customer exists", ex); }
    }

    public void UpdateCustomer(Customer customer)
    {
        throw new NotImplementedException();
    }

    public bool IsCustomerExists(int id)
    {
        throw new NotImplementedException();
    }
}
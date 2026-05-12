using BO;

namespace BlApi;

public interface ICustomer
{
    public IEnumerable<Customer?> GetAllCustomers();
    public Customer GetCustomerDetails(int id);
    public void AddCustomer(Customer customer);
    public void UpdateCustomer(Customer customer);
    public bool IsCustomerExists(int id); // הפונקציה המיוחדת מההנחיות
}
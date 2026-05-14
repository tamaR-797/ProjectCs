using DalApi;
using DO;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    private readonly string s_xml_file = "Customers";

    public int Create(Customer item)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file);
        int nextId = Config.NextCustomerId;
        var newItem = item with { CustId = nextId };
        list.Add(newItem);
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
        return nextId;
    }

    public Customer? Read(int id) =>
        XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file).FirstOrDefault(c => c?.CustId == id);

    public Customer? Read(Func<Customer, bool> filter) =>
        XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file).FirstOrDefault(c => c != null && filter(c));

    public List<Customer?> ReadAll(Func<Customer?, bool>? filter = null)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file);
        return filter == null ? list : list.Where(filter).ToList();
    }

    public void Update(Customer item)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file);
        int index = list.FindIndex(c => c?.CustId == item.CustId);
        if (index == -1) throw new IdNotFoundException(item.CustId.ToString());
        list[index] = item;
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
    }

    public void Delete(int id)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Customer>(s_xml_file);
        if (list.RemoveAll(c => c?.CustId == id) == 0) throw new IdNotFoundException(id.ToString());
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
    }
}
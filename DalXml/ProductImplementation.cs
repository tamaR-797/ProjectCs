using DalApi;

using DO;

namespace Dal;

internal class ProductImplementation : IProduct
{
    readonly string s_xml_file = "Products"; // XMLTools יוסיף .xml

    public int Create(Product item)
    {
        List<Product?> list = XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file);
        int nextId = Config.NextProductId;
        Product newItem = item with { ProdId = nextId }; // תיקון ל-ProdId
        list.Add(newItem);
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
        return nextId;
    }

    public Product? Read(int id) =>
        XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file).FirstOrDefault(p => p?.ProdId == id);

    public Product? Read(Func<Product, bool> filter) =>
        XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file).FirstOrDefault(p => p != null && filter(p));

    public List<Product?> ReadAll(Func<Product?, bool>? filter = null)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file);
        return filter == null ? list : list.Where(filter).ToList();
    }

    public void Update(Product item)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file);
        int index = list.FindIndex(p => p?.ProdId == item.ProdId);
        if (index == -1) throw new IdNotFoundException(item.ProdId.ToString());
        list[index] = item;
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
    }

    public void Delete(int id)
    {
        var list = XMLTools.LoadListFromXMLSerializer<Product>(s_xml_file);
        if (list.RemoveAll(p => p?.ProdId == id) == 0) throw new IdNotFoundException(id.ToString());
        XMLTools.SaveListToXMLSerializer(list, s_xml_file);
    }
}
using DalApi;
using DO;


namespace Dal;

internal class SaleImplementation : ISale
{
    // השינוי: הורדתי את @"xml\" ואת הסיומת, XMLTools מטפל בזה
    readonly string s_path = "sales";

    public int Create(Sale item)
    {
        List<Sale?> list = XMLTools.LoadListFromXMLSerializer<Sale>(s_path);

        // השינוי: קריאה למאפיין המתוקן ב-Config
        int nextId = Config.NextSaleId;

        Sale newItem = item with { SaleId = nextId };
        list.Add(newItem);

        XMLTools.SaveListToXMLSerializer(list, s_path);
        return nextId;
    }

    public Sale? Read(int id) =>
        XMLTools.LoadListFromXMLSerializer<Sale>(s_path).FirstOrDefault(s => s?.SaleId == id);

    public Sale? Read(Func<Sale, bool> filter) =>
        XMLTools.LoadListFromXMLSerializer<Sale>(s_path).FirstOrDefault(s => s != null && filter(s));

    public List<Sale?> ReadAll(Func<Sale?, bool>? filter = null)
    {
        List<Sale?> list = XMLTools.LoadListFromXMLSerializer<Sale>(s_path);
        return filter == null ? list : list.Where(filter).ToList();
    }

    public void Update(Sale item)
    {
        List<Sale?> list = XMLTools.LoadListFromXMLSerializer<Sale>(s_path);
        int index = list.FindIndex(s => s?.SaleId == item.SaleId);

        if (index == -1) throw new Exception($"Sale with ID {item.SaleId} not found");

        list[index] = item;
        XMLTools.SaveListToXMLSerializer(list, s_path);
    }

    public void Delete(int id)
    {
        List<Sale?> list = XMLTools.LoadListFromXMLSerializer<Sale>(s_path);
        if (list.RemoveAll(s => s?.SaleId == id) == 0) throw new Exception($"Sale with ID {id} not found");

        XMLTools.SaveListToXMLSerializer(list, s_path);
    }
}
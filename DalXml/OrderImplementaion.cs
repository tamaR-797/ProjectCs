using DalApi;
using DO;
using System.Reflection;
using Tools;

namespace Dal;

internal class OrderImplementaion : IOrder
{
    // השינוי: שם קובץ נקי
    readonly string s_orders_xml = "orders";

    public int Create(Order item)
    {
        LogManager.WriteToLog("DalXml", MethodBase.GetCurrentMethod()!.Name, $"XML: Creating order for customer: {item.CustomerId}");

        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);

        // השינוי: שימוש ב-NextOrderId מה-Config
        int nextId = Config.NextOrderId;
        Order finalizedItem = item with { Id = nextId };

        orders.Add(finalizedItem);
        XMLTools.SaveListToXMLSerializer(orders, s_orders_xml);

        return nextId;
    }

    public Order? Read(int id)
    {
        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);
        // השינוי: בדיקת null בסיסי
        return orders.FirstOrDefault(o => o?.Id == id);
    }

    public Order? Read(Func<Order, bool> filter)
    {
        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);
        return orders.FirstOrDefault(o => o != null && filter(o));
    }

    public List<Order?> ReadAll(Func<Order?, bool>? filter = null)
    {
        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);
        return filter == null ? orders : orders.Where(filter).ToList();
    }

    public void Update(Order item)
    {
        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);
        int index = orders.FindIndex(o => o?.Id == item.Id);

        if (index == -1)
            throw new IdNotFoundException($"Order ID {item.Id}");

        orders[index] = item;
        XMLTools.SaveListToXMLSerializer(orders, s_orders_xml);
    }

    public void Delete(int id)
    {
        List<Order?> orders = XMLTools.LoadListFromXMLSerializer<Order>(s_orders_xml);
        if (orders.RemoveAll(o => o?.Id == id) == 0)
            throw new IdNotFoundException($"Order ID {id}");

        XMLTools.SaveListToXMLSerializer(orders, s_orders_xml);
    }
}
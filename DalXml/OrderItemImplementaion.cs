using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

internal class OrderItemImplementaion : IOrderItem
{
    // שם הקובץ בתיקיית הנתונים
    readonly string s_orderItems_XML = "orderItems";
    public int Create(OrderItem item)
    {
        LogManager.WriteToLog("DalXml", MethodBase.GetCurrentMethod()!.Name, $"XML: Adding Product {item.ProductId} to Order {item.OrderId}");

        List<OrderItem?> items = XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML);
       
        items.Add(item);
        XMLTools.SaveListToXMLSerializer(items, s_orderItems_XML);

        return item.OrderId;
    }

    public OrderItem? Read(int id) =>
         XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML).FirstOrDefault(oi => oi?.OrderId == id);

    public OrderItem? Read(Func<OrderItem, bool> filter) =>
        XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML).FirstOrDefault(oi => oi != null && filter(oi));

    public List<OrderItem?> ReadAll(Func<OrderItem?, bool>? filter = null)
    {
        List<OrderItem?> items = XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML);
        return filter == null ? items : items.Where(filter).ToList();
    }

    public void Update(OrderItem item)
    {
        List<OrderItem?> items = XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML);
        // חיפוש לפי OrderId ו-ProductId (מפתח מורכב בדרך כלל)
        int index = items.FindIndex(oi => oi?.OrderId == item.OrderId && oi?.ProductId == item.ProductId);

        if (index == -1)
            throw new IdNotFoundException($"OrderItem with Order ID {item.OrderId} and Product ID {item.ProductId}");

        items[index] = item;
        XMLTools.SaveListToXMLSerializer(items, s_orderItems_XML);
    }

    public void Delete(int id)
    {
        List<OrderItem?> items = XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML);
        if (items.RemoveAll(oi => oi?.OrderId == id) == 0)
            throw new IdNotFoundException($"OrderItem with Order ID {id}");

        XMLTools.SaveListToXMLSerializer(items, s_orderItems_XML);
    }

    // --- מימוש מתודות ספציפיות מ-IOrderItem ---
    public IEnumerable<OrderItem> ReadAllByOrder(int orderId)
    {
        return XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML)
                       .Where(oi => oi != null && oi.OrderId == orderId)
                       .Cast<OrderItem>();
    }

    public OrderItem ReadByProductAndOrder(int orderId, int productId)
    {
        var item = XMLTools.LoadListFromXMLSerializer<OrderItem>(s_orderItems_XML)
                           .FirstOrDefault(oi => oi != null && oi.OrderId == orderId && oi.ProductId == productId);

        return item ?? throw new IdNotFoundException($"OrderItem with Order ID {orderId} and Product ID {productId}");
    }
}
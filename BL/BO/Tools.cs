using System.Reflection;
using System.Collections;

namespace BO;

internal static class Tools
{
    // מתודת הרחבה ל-ToString מבוסס Reflection
    public static string ToStringProperty<T>(this T obj)
    {
        if (obj == null) return "";
        string str = "";
        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {
            var value = item.GetValue(obj, null);
            if (value is IEnumerable enumerable && !(value is string))
            {
                str += $"\n{item.Name}:";
                foreach (var element in enumerable)
                    str += $"\n  {element}";
            }
            else
            {
                str += $"\n{item.Name}: {value ?? "null"}";
            }
        }
        return str;
    }

    // פונקציית המרה: מוצר מ-DO ל-BO
    public static BO.Product ToBO(this DO.Product doProd)
    {
        return new BO.Product
        {
            ProdId = doProd.ProdId,
            ProdName = doProd.ProdName,
            ProdPrice = doProd.ProdPrice ?? 0,
            InStock = doProd.QuantityInStock ?? 0, // התאמה לשם ב-DO
            Category = doProd.category != null ? (BO.Categories)doProd.category : default
        };
    }

    // פונקציית המרה: לקוח מ-DO ל-BO
    public static BO.Customer ToBO(this DO.Customer doCust)
    {
        return new BO.Customer
        {
            CustId = doCust.CustId,
            CustName = doCust.CustName,
            CustAddress = doCust.CustAddress,
            CustPhone = doCust.CustPhone
        };
    }
}
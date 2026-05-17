
using System;
using System.Collections;
using System.Reflection;
using System.Text;

namespace BO
{
    internal static class Tools
    {
        // מתודת הרחבה גנרית להדפסת אובייקט באמצעות Reflection (כולל תמיכה ברשימות פנימיות)
        public static string ToStringProperty<T>(this T t)
        {
            if (t == null) return string.Empty;

            StringBuilder sb = new StringBuilder();
            Type type = t.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                object? value = property.GetValue(t, null);

                // טיפול במקרה של אוספים ורשימות שאינם מחרוזת (כמו List<ProductInOrder>)
                if (typeof(IEnumerable).IsAssignableFrom(property.PropertyType) && property.PropertyType != typeof(string))
                {
                    sb.AppendLine($"{property.Name}:");
                    IEnumerable? enumerable = value as IEnumerable;
                    if (enumerable != null)
                    {
                        foreach (var item in enumerable)
                        {
                            if (item != null)
                            {
                                // זימון המתודה הסטטית עבור האיבר הבודד באוסף למניעת שגיאת הקומפילציה
                                sb.Append(Tools.ToStringProperty(item));
                            }
                        }
                    }
                }
                else
                {
                    // הדפסת מאפיין פשוט
                    sb.AppendLine($"{property.Name}: {value ?? "null"}");
                }
            }

            return sb.ToString();
        }

        // ==========================================
        // פונקציות המרה (Mappers) בין שכבת DO לשכבת BO
        // ==========================================

        public static DO.Product ConvertToDO(this BO.Product p)
        {
            return new DO.Product
            {
                ProdId = p.ProdId,
                ProdName = p.ProdName,
                category = p.Category != null ? (DO.Categories)Enum.Parse(typeof(DO.Categories), p.Category.ToString()) : null,
                ProdPrice = p.ProdPrice,
                QuantityInStock = p.QuantityInStock
            };
        }

        public static BO.Product ConvertToBO(this DO.Product p)
        {
            return new BO.Product
            (
                ProdId: p.ProdId,
                ProdName: p.ProdName,
                category: p.category != null ? (BO.Categories?)Enum.Parse(typeof(BO.Categories), p.category.ToString()) : null,
                ProdPrice: p.ProdPrice ?? 0,
                QuantityInStock: p.QuantityInStock ?? 0
            );
        }

        public static DO.Customer ConvertToDO(this BO.Customer c)
        {
            return new DO.Customer
            {
                CustId = c.CustId,
                CustName = c.CustName,
                CustPhone = c.CustPhone,
                CustAddress = c.CustAddress
            };
        }

        public static BO.Customer ConvertToBO(this DO.Customer c)
        {
            return new BO.Customer
            (
                CustId: c.CustId,
                CustName: c.CustName,
                CustAddress: c.CustAddress,
                CustPhone: c.CustPhone
            );
        }

        public static DO.Sale ConvertToDO(this BO.Sale s)
        {
            return new DO.Sale
            {
                SaleId = s.SaleId,
                ProdId = s.ProdId,
                QuantitySale = s.QuantitySale,
                SalePrice = s.SalePrice,
                IsClub = s.IsClub,
                StartDate = s.StartDate,
                EndDate = s.EndDate
            };
        }

        public static BO.Sale ConvertToBO(this DO.Sale s)
        {
            return new BO.Sale
            (
                SaleId: s.SaleId,
                ProdId: s.ProdId,
                QuantitySale: s.QuantitySale ?? 0,
                SalePrice: s.SalePrice ?? 0,
                IsClub: s.IsClub ?? false,
                StartDate: s.StartDate,
                EndDate: s.EndDate
            );
        }

        public static BO.SaleInProduct ConvertSaleToSaleInProduct(this DO.Sale s)
        {
            return new BO.SaleInProduct
            (
                ProdId: s.ProdId,
                QuantityInSale: s.QuantitySale ?? 0,
                Price: s.SalePrice ?? 0,
                ForClub: s.IsClub ?? false
            );
        }
    }
}

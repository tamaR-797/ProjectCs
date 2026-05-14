using System.Xml.Linq;
using System.IO;

namespace Dal
{
    internal static class Config
    {
        // הנתיב המלא לקובץ הקונפיגורציה בתוך תיקיית ה-xml
        private static string s_config_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xml", "data-config.xml");

        internal static int NextSaleId => GetAndIncrement("staticValueSale");
        internal static int NextCustomerId => GetAndIncrement("staticValueCustomer");
        internal static int NextProductId => GetAndIncrement("staticValueProduct");
        internal static int NextOrderId => GetAndIncrement("staticValueOrder");
        internal static int NextOrderItemId => GetAndIncrement("staticValueOrderItem");

        private static int GetAndIncrement(string elementName)
        {
            if (!File.Exists(s_config_path))
            {
                // יצירת קובץ ברירת מחדל אם הוא לא קיים כדי למנוע קריסה ראשונית
                XElement initial = new XElement("config",
                    new XElement("staticValueSale", "1000"),
                    new XElement("staticValueCustomer", "1000"),
                    new XElement("staticValueProduct", "1000"),
                    new XElement("staticValueOrder", "1000"),
                    new XElement("staticValueOrderItem", "1000")
                );
                string? dir = Path.GetDirectoryName(s_config_path);
                if (dir != null && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                initial.Save(s_config_path);
            }

            try
            {
                XElement root = XElement.Load(s_config_path);
                XElement node = root.Element(elementName) ?? throw new Exception($"Element {elementName} missing in config");

                int currentVal = int.Parse(node.Value);
                node.Value = (currentVal + 1).ToString();
                root.Save(s_config_path);

                return currentVal;
            }
            catch (Exception ex)
            {
                throw new Exception($"שגיאה בגישה לנתוני קונפיגורציה: {ex.Message}");
            }
        }

    }
}
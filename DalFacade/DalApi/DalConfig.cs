using System.Xml.Linq;
using System.IO;

namespace DalApi;

internal static class DalConfig
{
    // אלו המשתנים שיכילו את המידע שנקרא מה-XML
    internal static string s_dalName;
    internal static Dictionary<string, string> s_dalPackages;

    // זהו בנאי סטטי - הוא רץ אוטומטית פעם אחת כשהתוכנית מתחילה
    static DalConfig()
    {
        // שליפת הנתיב לקובץ dal-config.xml שנמצא בתיקיית xml
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "xml", "dal-config.xml");

        if (!File.Exists(path))
            throw new DalConfigException($"Missing configuration file: {path}");

        try
        {
            XElement config = XElement.Load(path);

            // קריאת הערך xml או list
            s_dalName = config.Element("dal")?.Value
                        ?? throw new DalConfigException("<dal> element is missing in dal-config.xml");

            // יצירת המילון שמקשר בין השם (xml) לשם הפרויקט (DalXml)
            var packages = config.Element("dal-packages")?.Elements()
                           ?? throw new DalConfigException("<dal-packages> element is missing in dal-config.xml");

            s_dalPackages = packages.ToDictionary(e => e.Name.LocalName, e => e.Value);
        }
        catch (Exception ex)
        {
            throw new DalConfigException($"Failed to load dal-config.xml: {ex.Message}", ex);
        }
    }
}
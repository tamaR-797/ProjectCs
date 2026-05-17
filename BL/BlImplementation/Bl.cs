using BL.BlApi;
using BlApi;
using BO;

namespace BL.BlImplementation;

internal class Bl : BL.BlApi.IBl
{
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();
    public IOrder Order => new OrderImplementation();
}
//using BL.BlApi;
//using BlApi; // namespace של הממשק ICart שלך
//using BO;

//namespace BL.BlImplementation;

//internal class Bl : BL.BlApi.IBl
//{
//    // משאירים רק את מה ששייך ללוגיקה העסקית האמיתית
//    public IProduct Product => throw new NotImplementedException(); // כאן יבוא מימוש ה-Product הלוגי שלכן בהמשך
//    public ICustomer Customer => throw new NotImplementedException(); // כאן יבוא מימוש ה-Customer הלוגי שלכן בהמשך
//    public ISale Sale => throw new NotImplementedException();
//    public IOrder Order => new OrderImplementation();
//    public ICart Cart => new CartImplementation(); // מחזיר את המימוש המתוקן של העגלה
//}
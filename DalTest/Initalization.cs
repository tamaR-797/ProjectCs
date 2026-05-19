using DO;
using DalApi;
using Dal;

namespace DalTest;

public static class Initalization
{
    private static IDal s_dal;
    private static List<int> s_productIds = new List<int>();

    private static void createSale(ISale si)
    {

        si.Create(new Sale(1, s_productIds[0], 5, 100,  true, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(8)));
        si.Create(new Sale(2, s_productIds[0], 30, 200,  false, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(15)));
        si.Create(new Sale(3, s_productIds[2], 20, 150, true, DateTime.Now.AddDays(1), DateTime.Now.AddDays(10)));
        si.Create(new Sale(4, s_productIds[2], 25, 300,  false, DateTime.Now.AddDays(-1), DateTime.Now.AddDays(16)));
        si.Create(new Sale(5, s_productIds[2], 15, 250,  true, DateTime.Now.AddDays(2), DateTime.Now.AddDays(12)));
        si.Create(new Sale(6, s_productIds[3], 35, 120, false, DateTime.Now.AddDays(5), DateTime.Now.AddDays(10)));
        si.Create(new Sale(7, s_productIds[3], 45, 180,  true, DateTime.Now, DateTime.Now.AddDays(1)));
        si.Create(new Sale(8, s_productIds[4], 55, 220,  false, DateTime.Now, DateTime.Now.AddDays(10)));


    }
    private static void createCustomer(ICustomer ci)
    {

        ci.Create(new Customer(1, "Tamar", "Herzel 5", "0583295797", true));
        ci.Create(new Customer(2, "Shira", "Ben Gurion 10", "05556706410", false));
        ci.Create(new Customer(3, "Tovi", "Jabotinsky 3", "0556751892", false));
        ci.Create(new Customer(4, "Dvora", "Hertzelia", "0556743432", true));
        ci.Create(new Customer(5, "Dvory", "Rabi akiva", "57453243", false));
        ci.Create(new Customer(6, "Tamar", "Petah Tikva", "235437548", true));
        ci.Create(new Customer(7, "Bina", "Mesilat yosef", "45636457", false));
        ci.Create(new Customer(8, "Shosh", "Rashbi", "7456634", true));
        ci.Create(new Customer(9, "Tsipora", "Meromei Sade", "6547568", false));
        ci.Create(new Customer(10, "Yael", "Chazon david", "42556578", true));
        ci.Create(new Customer(11, "Shimon", "Yatkovski 7", "6435342", true));
        ci.Create(new Customer(12, "David", "Mesilat", "3534645", false));
        ci.Create(new Customer(13, "Kobi", "Meromei Sade", "657658", true));

    }
    private static void createProduct(IProduct pi)
    {
        s_productIds.Add( pi.Create(new Product(1001,  Categories.SHIRTS, "Puma",100, 50)));
        s_productIds.Add(pi.Create(new Product(2, Categories.PANTS, "Adidas", 150, 30)));
        s_productIds.Add(pi.Create(new Product(3, Categories.SOCKS, "Reebok", 80, 70)));
        s_productIds.Add(pi.Create(new Product(4, Categories.PANTS, "Nike", 200, 20)));
        s_productIds.Add(pi.Create(new Product(5,  Categories.SOCKS,"Puma", 50, 100)));
        s_productIds.Add(pi.Create(new Product(6,  Categories.DRESSES,"Castro", 300, 15)));
        s_productIds.Add(pi.Create(new Product(7, Categories.PAJAMS, "Fox", 250, 25)));
        s_productIds.Add(pi.Create(new Product(8,  Categories.SHIRTS,"Renuar", 180, 40)));
        s_productIds.Add(pi.Create(new Product(9,  Categories.DRESSES,"Zara", 400, 10)));
    }
    public static void initialize()
    {
        s_dal = Factory.Get;
        createSale(s_dal.Sale);
        createCustomer(s_dal.Customer);
        createProduct(s_dal.Product);
    }
}




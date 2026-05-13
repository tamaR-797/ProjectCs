using BlApi;
using BO;

namespace BlTest;

internal class Program
{
    // הגדרת שדה עבור הממשק הראשי של השכבה הלוגית כפי שהתבקש
    static readonly IBl s_bl = Factory.Get();

    static void Main(string[] args)
    {
        // קריאה לאתחול הנתונים מתוך DalTest (במידה והוספת Reference)
        // DalTest.Program.Initialization(); 

        Console.WriteLine("=== Store Management System - BL Testing ===");

        string? choice;
        do
        {
            Console.WriteLine("\nChoose an entity to test:");
            Console.WriteLine("1: Product Management");
            Console.WriteLine("2: Customer Management");
            Console.WriteLine("3: Sales & Orders Management");
            Console.WriteLine("4: Cart Simulator (Shopping)");
            Console.WriteLine("0: Exit");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();

            try
            {
                switch (choice)
                {
                    case "1": ProductSubMenu(); break;
                    case "2": CustomerSubMenu(); break;
                    case "3": SaleSubMenu(); break;
                    case "4": CartSubMenu(); break;
                    case "0": Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid selection."); break;
                }
            }
            catch (Exception ex)
            {
                // הדפסת שגיאות לוגיות מה-BL (כמו "מוצר לא נמצא" או "חוסר במלאי")
                Console.WriteLine($"\n[BL ERROR]: {ex.Message}");
            }
        } while (choice != "0");
    }

    #region Product Sub-Menu
    static void ProductSubMenu()
    {
        Console.WriteLine("\n--- Product Operations ---");
        Console.WriteLine("a: Show all products");
        Console.WriteLine("b: Show product details by ID");
        Console.WriteLine("c: Add new product");
        Console.Write("Choose: ");
        char choice = char.Parse(Console.ReadLine()!);

        switch (choice)
        {
            case 'a':
                foreach (var p in s_bl.Product.GetAllProducts()) Console.WriteLine(p);
                break;
            case 'b':
                Console.Write("Enter product ID: ");
                int id = int.Parse(Console.ReadLine()!);
                Console.WriteLine(s_bl.Product.GetProductDetails(id));
                break;
            case 'c':
                // כאן ניתן להוסיף קליטת נתונים למוצר חדש
                Console.WriteLine("Adding product feature...");
                break;
        }
    }
    #endregion

    #region Customer Sub-Menu
    static void CustomerSubMenu()
    {
        Console.WriteLine("\n--- Customer Operations ---");
        Console.WriteLine("a: Show all customers");
        Console.WriteLine("b: Show customer details");
        Console.Write("Choose: ");
        char choice = char.Parse(Console.ReadLine()!);

        if (choice == 'a')
        {
            foreach (var c in s_bl.Customer.GetAllCustomers()) Console.WriteLine(c);
        }
        else if (choice == 'b')
        {
            Console.Write("Enter customer ID: ");
            int id = int.Parse(Console.ReadLine()!);
            Console.WriteLine(s_bl.Customer.GetCustomerDetails(id));
        }
    }
    #endregion

    #region Sale & Order Sub-Menu
    static void SaleSubMenu()
    {
        Console.WriteLine("\n--- Sales Operations ---");
        Console.WriteLine("a: Show sales list (Overview)");
        Console.Write("Choose: ");

        if (Console.ReadLine()?.ToLower() == "a")
        {
            try
            {
                var sales = s_bl.Sale.GetSalesList();

                if (sales == null || !sales.Any())
                {
                    Console.WriteLine("No sales found in the system.");
                    return;
                }

                foreach (var s in sales)
                {
                    // שימוש ב-ToString האוטומטי של ה-BO
                    Console.WriteLine(s);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving sales: {ex.Message}");
            }
        }
    }
    #endregion

    #region Cart Sub-Menu (Simulator)
    static void CartSubMenu()
    {
        // יצירת עגלה חדשה לבדיקת ה-Simulation
        Cart myCart = new Cart { Items = new List<ItemInCart?>(), FinalPrice = 0 };

        bool exitCart = false;
        while (!exitCart)
        {
            Console.WriteLine("\n--- Cart Simulator ---");
            Console.WriteLine("1: Add product to cart");
            Console.WriteLine("2: View cart");
            Console.WriteLine("3: Confirm order (Checkout)");
            Console.WriteLine("0: Back to main menu");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter product ID: ");
                    int pid = int.Parse(Console.ReadLine()!);
                    myCart = s_bl.Cart.AddProductToCart(myCart, pid);
                    Console.WriteLine("Product added.");
                    break;
                case "2":
                    Console.WriteLine(myCart);
                    break;
                case "3":
                    s_bl.Cart.ConfirmOrder(myCart);
                    Console.WriteLine("Order confirmed successfully!");
                    exitCart = true;
                    break;
                case "0": exitCart = true; break;
            }
        }
    }
    #endregion
}
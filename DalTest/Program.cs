using DalApi;
using DO;
using Tools;


namespace DalTest;
public class program
{
    private static readonly IDal s_dal = DalApi.Factory.Get;
    public static void Main()
    {
        try
        {
            Initalization.initialize();
            Console.WriteLine("Data initialization completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred during DAL initialization: {ex.Message}");
            return;
        }
        int num = 0;
        do
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine("1. Customer DAL");
            Console.WriteLine("2. Product DAL");
            Console.WriteLine("3. Sale DAL");
            Console.WriteLine("4. Order DAL (New!)");     // הוספה
            Console.WriteLine("5. OrderItem DAL (New!)"); // הוספה
            Console.WriteLine("6. Delete Old Logs");
            Console.WriteLine("0. Exit");

            if (!int.TryParse(Console.ReadLine(), out num)) continue;

            switch (num)
            {
                case 1: CRUD(s_dal.Customer, detailsCustomer, "Customer"); break;
                case 2: CRUD(s_dal.Product, detailsProduct, "Product"); break;
                case 3: CRUD(s_dal.Sale, detailsSale, "Sale"); break;
                case 4: CRUD(s_dal.Order, detailsOrder, "Order"); break; // הוספה
                case 5: CRUDitem(s_dal.OrderItem); break; // טיפול מיוחד בגלל המתודות הנוספות
                case 6: LogManager.DeleteOldLogs(); break;
                case 0: Console.WriteLine("Exiting..."); break;
            }
        } while (num != 0);

    }
    // מתודה גנרית לחיסכון בקוד - מטפלת בכל הישויות באותו אופן!
    private static void CRUD<T>(ICrud<T> dal, Func<int, T> getDetails, string name) where T : class
    {
        int choice = showMenu(name);
        try
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"New ID: {dal.Create(getDetails(0))}");
                    break;
                case 2:
                    var result = dal.Read(getId());
                    Console.WriteLine(result?.ToString() ?? "Not Found");
                    break;
                case 3:
                    dal.Update(getDetails(getId()));
                    break;
                case 4:
                    dal.Delete(getId());
                    break;
                case 5:
                    var all = dal.ReadAll();
                    if (all != null)
                        foreach (var x in all) Console.WriteLine(x);
                    break;
            }
        }
        catch (Exception ex) { Console.WriteLine($"Error: {ex.Message}"); }
    }
    // מימוש ספציפי ל-OrderItem בגלל המתודות המיוחדות שלו
    private static void CRUDitem(IOrderItem dal)
    {
        int choice = showMenu("OrderItem");
        if (choice == 5) dal.ReadAll().ForEach(x => Console.WriteLine(x));
        if (choice == 1) dal.Create(detailsOrderItem(0));
        // כאן אפשר להוסיף קריאות ל-ReadAllByOrder וכו'
    }

    // --- עזרי קלט ---

    private static Order detailsOrder(int id) {
        Console.WriteLine("Enter Customer ID for this order:");
        int custId = int.Parse(Console.ReadLine()!);
        return new Order { Id = id, CustomerId = custId, OrderDate = DateTime.Now };
    }
    private static OrderItem detailsOrderItem(int id)
    {
        Console.WriteLine("Enter Order ID and Product ID:");
        return new OrderItem { OrderId = int.Parse(Console.ReadLine()!), ProductId = int.Parse(Console.ReadLine()!) };
    }

    private static int getId()
    {
        Console.Write("Enter ID: ");
        return int.Parse(Console.ReadLine()!);
    }

    private static int showMenu(string entity)
    {
        Console.WriteLine($"\n--- {entity} Menu ---");
        Console.WriteLine("1. Create\n2. Read\n3. Update\n4. Delete\n5. Read All\n6. Back");
        return int.Parse(Console.ReadLine()!);
    }
    private static Customer detailsCustomer(int id = 0)
    {
        Console.WriteLine("Please enter the customer details: ");
        Console.WriteLine("Name: ");
        Console.WriteLine("Address: ");
        Console.WriteLine("Phone: ");
        string name = Console.ReadLine()!;
        string address = Console.ReadLine()!;
        string phone = Console.ReadLine()!;
        return new Customer(id, name, address, phone);
    }
    private static Product detailsProduct(int id = 0)
    {
        Console.WriteLine("Please enter the product details: ");
        Console.WriteLine("Name: ");
        string name = Console.ReadLine()!;
        Console.WriteLine("Category: ");
        Categories category = (Categories)Enum.Parse(typeof(Categories), Console.ReadLine()!);
        Console.WriteLine("Price: ");
        double price = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantity in stock:  ");
        int quantity = int.Parse(Console.ReadLine()!);
        return new Product(id, name, category, price, quantity);
    }
    private static Sale detailsSale(int id = 0)
    {
        Console.WriteLine("Please enter the sale details: ");
        Console.WriteLine("Product ID: ");
        int productId = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Quantity: ");
        int quantity = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Price per unit: ");
        double pricePerUnit = double.Parse(Console.ReadLine()!);
        Console.WriteLine("Is delivered (true/false): ");
        bool isDelivered = bool.Parse(Console.ReadLine()!);
        Console.WriteLine("start date (yyyy-MM-dd) or leave empty: ");
        string startDateInput = Console.ReadLine()!;
        DateTime? startDate = string.IsNullOrWhiteSpace(startDateInput) ? DateTime.Now : DateTime.Parse(startDateInput);
        Console.WriteLine("end date (yyyy-MM-dd) or leave empty: ");
        string endDateInput = Console.ReadLine()!;
        DateTime? endDate = string.IsNullOrWhiteSpace(endDateInput) ? DateTime.Now : DateTime.Parse(endDateInput);
        return new Sale(id, productId, quantity, pricePerUnit, isDelivered, startDate, endDate);
    }
   
}

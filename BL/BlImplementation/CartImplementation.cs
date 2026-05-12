using System.Linq; // חובה בשביל ה-FirstOrDefault וה-Sum
using System.Collections.Generic;
using BO;
using BlApi;

namespace BlImplementation;

internal class CartImplementation : BlApi.ICart
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public BO.Cart AddProductToCart(BO.Cart cart, int id)
    {
        // קבלת נתוני המוצר מה-DAL
        DO.Product p = _dal.Product.Read(id) ?? throw new Exception("Product not found");

        // בדיקה אם יש מלאי
        if (p.QuantityInStock <= 0) throw new Exception("Out of stock");

        // בדיקה אם המוצר כבר קיים בסל
        var item = cart.Items?.FirstOrDefault(i => i.ProdId == id);

        if (item != null)
        {
            item.Quantity++;
            item.TotalPrice = item.Quantity * item.Price;
        }
        else
        {
            // אם המוצר לא בסל, מוסיפים אותו כחדש
            var newList = cart.Items?.ToList() ?? new List<BO.ItemInCart>();
            newList.Add(new BO.ItemInCart
            {
                ProdId = id,
                ProdName = p.ProdName,
                Price = p.ProdPrice ?? 0,
                Quantity = 1,
                TotalPrice = p.ProdPrice ?? 0
            });
            cart.Items = newList;
        }

        // עדכון המחיר הכולל של הסל
        cart.FinalPrice = cart.Items.Sum(i => i.TotalPrice);
        return cart;
    }

    public BO.Cart UpdateProductQuantity(BO.Cart cart, int id, int quantity) => throw new NotImplementedException();

    public int ConfirmOrder(BO.Cart cart)
    {
        // לוגיקה לבדיקת מלאי סופית
        foreach (var item in cart.Items!)
        {
            var p = _dal.Product.Read(item.ProdId);
            if (p?.QuantityInStock < item.Quantity)
                throw new Exception($"Not enough stock for {item.ProdName}");
        }

        // כאן יבוא בהמשך הקוד ליצירת ההזמנה ב-DAL
        return 0;
    }

    public Cart UpdateQuantity(Cart cart, int productId, int newQuantity)
    {
        throw new NotImplementedException();
    }

    void ICart.ConfirmOrder(Cart cart)
    {
        throw new NotImplementedException();
    }
}
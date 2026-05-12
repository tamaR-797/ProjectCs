using BO;

namespace BlApi;

public interface ICart
{
    public Cart AddProductToCart(Cart cart, int productId); // מוסיף מוצר ומחשב מבצעים
    public Cart UpdateQuantity(Cart cart, int productId, int newQuantity);
    public void ConfirmOrder(Cart cart); // סגירת חשבון ועדכון מלאי ב-DAL
}
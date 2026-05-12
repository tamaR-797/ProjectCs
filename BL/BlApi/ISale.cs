using BO;

namespace BlApi;

public interface ISale
{
    public IEnumerable<Sale?> GetAllSales();
    public Sale GetSaleDetails(int id);
    public void AddSale(Sale sale);
    public void UpdateSale(Sale sale);
    public void DeleteSale(int id);

    // פונקציית עזר לוגית: קבלת כל המבצעים הפעילים עבור מוצר ספציפי
    public IEnumerable<Sale?> GetActiveSalesByProduct(int productId);
}
namespace BO;

public class Sale
{
    public int SaleId { get; init; }
    public int ProdId { get; set; }
    public int RequiredQuantity { get; set; }
    public double SalePrice { get; set; }
    public bool IsMemberOnly { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

    public override string ToString() => this.ToStringProperty();
}
namespace BO;

public class ItemInCart
{
    public int ProdId { get; set; }
    public string? ProdName { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public double TotalPrice { get; set; }

    public override string ToString() => this.ToStringProperty();
}
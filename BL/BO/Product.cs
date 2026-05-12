namespace BO;

public class Product
{
    public int ProdId { get; init; }
    public string? ProdName { get; set; }
    public Categories Category { get; set; }
    public double ProdPrice { get; set; }
    public int InStock { get; set; }

    public override string ToString() => this.ToStringProperty();
}
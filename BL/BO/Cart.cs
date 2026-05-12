namespace BO;

public class Cart
{
    public int CustomerId { get; set; }
    public string? CustomerName { get; set; }
    public List<ItemInCart?>? Items { get; set; }
    public double FinalPrice { get; set; }

    public override string ToString() => this.ToStringProperty();
}
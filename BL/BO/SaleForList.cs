namespace BO;

public class SaleForList
{
    public int OrderId { get; set; }
    public string? CustomerName { get; set; }
    public int AmountOfItems { get; set; }
    public double TotalPrice { get; set; }

    public override string ToString() => $@"
        Order ID: {OrderId}
        Customer: {CustomerName}
        Items:    {AmountOfItems}
        Total:    {TotalPrice} NIS";
}
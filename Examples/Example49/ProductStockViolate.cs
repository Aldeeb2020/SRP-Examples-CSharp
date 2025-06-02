public class Product
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }

    public void NotifyLowStock()
    {
        Console.WriteLine($"Notifying low stock: {Stock}.");
    }
}

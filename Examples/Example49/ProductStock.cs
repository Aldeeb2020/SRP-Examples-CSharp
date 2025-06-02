public class Product
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }
}

public class StockNotifier
{
    public void NotifyLowStock(Product product)
    {
        Console.WriteLine($"Notifying low stock: {product.Stock}.");
    }
}

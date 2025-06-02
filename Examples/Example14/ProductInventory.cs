public class ProductInventory
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }
}

public class PricingService
{
    public decimal CalculatePrice(ProductInventory product)
    {
        Console.WriteLine("Calculating price.");
        return product.Stock * 10m;
    }
}

public class Product
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }

    public decimal CalculatePrice()
    {
        Console.WriteLine("Calculating price.");
        return Stock * 10m;
    }
}

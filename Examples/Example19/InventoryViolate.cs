public class Inventory
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"Generating inventory report: {Stock} items.");
    }
}

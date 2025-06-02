public class Inventory
{
    public int Stock { get; set; }

    public void UpdateStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"Updated stock to {Stock}.");
    }
}

public class ReportGenerator
{
    public void GenerateReport(Inventory inventory)
    {
        Console.WriteLine($"Generating inventory report: {inventory.Stock} items.");
    }
}

public class OrderHistory
{
    public List<int> Orders { get; set; } = new List<int>();

    public void AddOrder(int orderId)
    {
        Orders.Add(orderId);
        Console.WriteLine($"Added order {orderId}.");
    }
}

public class ReportGenerator
{
    public void GenerateReport(OrderHistory history)
    {
        Console.WriteLine($"Generating report for {history.Orders.Count} orders.");
    }
}

public class OrderHistory
{
    public List<int> Orders { get; set; } = new List<int>();

    public void AddOrder(int orderId)
    {
        Orders.Add(orderId);
        Console.WriteLine($"Added order {orderId}.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"Generating report for {Orders.Count} orders.");
    }
}

public class Customer
{
    public List<int> Orders { get; set; } = new List<int>();

    public void AddOrder(int orderId)
    {
        Orders.Add(orderId);
        Console.WriteLine($"Added order {orderId}.");
    }

    public void GenerateBill()
    {
        Console.WriteLine($"Generating bill for {Orders.Count} orders.");
    }
}

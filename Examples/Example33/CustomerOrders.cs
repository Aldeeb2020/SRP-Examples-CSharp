public class CustomerOrders
{
    public List<int> Orders { get; set; } = new List<int>();

    public void AddOrder(int orderId)
    {
        Orders.Add(orderId);
        Console.WriteLine($"Added order {orderId}.");
    }
}

public class BillingService
{
    public void GenerateBill(CustomerOrders customer)
    {
        Console.WriteLine($"Generating bill for {customer.Orders.Count} orders.");
    }
}

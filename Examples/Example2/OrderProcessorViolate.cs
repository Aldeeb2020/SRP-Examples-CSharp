public class OrderProcessor
{
    public void ProcessOrder(int orderId)
    {
        // Process order
        Console.WriteLine($"Processing order {orderId}.");
        
        // Log order
        Console.WriteLine($"Logging order {orderId} to file.");
    }
}

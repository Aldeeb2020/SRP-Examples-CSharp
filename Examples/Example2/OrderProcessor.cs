public class OrderProcessor
{
    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"Processing order {orderId}.");
    }
}

public class Logger
{
    public void LogOrder(int orderId)
    {
        Console.WriteLine($"Logging order {orderId} to file.");
    }
}

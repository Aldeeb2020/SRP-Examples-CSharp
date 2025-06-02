public class PaymentGateway
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}.");
    }
}

public class PaymentLogger
{
    public void LogPayment(decimal amount)
    {
        Console.WriteLine($"Logging payment of {amount}.");
    }
}

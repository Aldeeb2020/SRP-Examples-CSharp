public class PaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing payment of {amount}.");
    }

    public void GenerateReceipt()
    {
        Console.WriteLine("Generating receipt.");
    }
}

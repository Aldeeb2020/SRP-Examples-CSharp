public class Order
{
    public decimal Amount { get; set; }

    public void ProcessPayment()
    {
        Console.WriteLine($"Processing payment of {Amount}.");
    }

    public void GenerateReceipt()
    {
        Console.WriteLine($"Generating receipt for {Amount}.");
    }
}

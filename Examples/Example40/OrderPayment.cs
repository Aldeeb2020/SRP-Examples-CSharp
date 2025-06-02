public class Order
{
    public decimal Amount { get; set; }

    public void ProcessPayment()
    {
        Console.WriteLine($"Processing payment of {Amount}.");
    }
}

public class ReceiptGenerator
{
    public void GenerateReceipt(Order order)
    {
        Console.WriteLine($"Generating receipt for {order.Amount}.");
    }
}

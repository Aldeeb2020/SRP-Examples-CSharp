public class Payment
{
    public decimal Amount { get; set; }

    public bool ValidatePayment()
    {
        Console.WriteLine($"Validating payment of {Amount}.");
        return true;
    }

    public void SendPaymentNotification()
    {
        Console.WriteLine($"Sending payment notification for {Amount}.");
    }
}

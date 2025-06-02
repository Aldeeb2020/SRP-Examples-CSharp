public class Payment
{
    public decimal Amount { get; set; }

    public bool ValidatePayment()
    {
        Console.WriteLine($"Validating payment of {Amount}.");
        return true;
    }
}

public class NotificationService
{
    public void SendPaymentNotification(Payment payment)
    {
        Console.WriteLine($"Sending payment notification for {payment.Amount}.");
    }
}

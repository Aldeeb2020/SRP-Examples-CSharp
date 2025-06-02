public class Order
{
    public int Id { get; set; }

    public void ConfirmOrder()
    {
        Console.WriteLine($"Confirming order {Id}.");
    }
}

public class EmailService
{
    public void SendEmail(Order order)
    {
        Console.WriteLine($"Sending email for order {order.Id}.");
    }
}

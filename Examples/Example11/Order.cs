public class Order
{
    public int Id { get; set; }

    public bool ValidateOrder()
    {
        Console.WriteLine($"Validating order {Id}.");
        return true;
    }
}

public class EmailService
{
    public void SendConfirmationEmail(Order order)
    {
        Console.WriteLine($"Sending confirmation email for order {order.Id}.");
    }
}

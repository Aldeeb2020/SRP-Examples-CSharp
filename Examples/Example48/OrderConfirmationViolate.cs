public class Order
{
    public int Id { get; set; }

    public void ConfirmOrder()
    {
        Console.WriteLine($"Confirming order {Id}.");
    }

    public void SendEmail()
    {
        Console.WriteLine($"Sending email for order {Id}.");
    }
}

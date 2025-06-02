public class Order
{
    public int Id { get; set; }

    public bool ValidateOrder()
    {
        Console.WriteLine($"Validating order {Id}.");
        return true;
    }

    public void SendConfirmationEmail()
    {
        Console.WriteLine($"Sending confirmation email for order {Id}.");
    }
}

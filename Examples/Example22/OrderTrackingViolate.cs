public class Order
{
    public int Id { get; set; }

    public void TrackOrder()
    {
        Console.WriteLine($"Tracking order {Id}.");
    }

    public void NotifyCustomer()
    {
        Console.WriteLine($"Notifying customer about order {Id}.");
    }
}

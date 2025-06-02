public class Order
{
    public int Id { get; set; }

    public void DeliverOrder()
    {
        Console.WriteLine($"Delivering order {Id}.");
    }

    public void TrackDelivery()
    {
        Console.WriteLine($"Tracking delivery for order {Id}.");
    }
}

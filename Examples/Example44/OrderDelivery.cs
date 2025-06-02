public class OrderDelivery
{
    public int Id { get; set; }

    public void DeliverOrder()
    {
        Console.WriteLine($"Delivering order {Id}.");
    }
}

public class TrackingService
{
    public void TrackDelivery(OrderDelivery order)
    {
        Console.WriteLine($"Tracking delivery for order {order.Id}.");
    }
}

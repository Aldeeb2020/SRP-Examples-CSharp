public class OrderTracker
{
    public int Id { get; set; }

    public void TrackOrder()
    {
        Console.WriteLine($"Tracking order {Id}.");
    }
}

public class NotificationService
{
    public void NotifyCustomer(OrderTracker order)
    {
        Console.WriteLine($"Notifying customer about order {order.Id}.");
    }
}

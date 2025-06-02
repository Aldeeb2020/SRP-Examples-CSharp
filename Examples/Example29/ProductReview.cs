public class ProductReview
{
    public string Review { get; set; }

    public void SaveReview()
    {
        Console.WriteLine($"Saving review: {Review}.");
    }
}

public class NotificationService
{
    public void NotifyAdmin()
    {
        Console.WriteLine("Notifying admin about review.");
    }
}

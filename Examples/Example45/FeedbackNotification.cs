public class Feedback
{
    public string Comment { get; set; }

    public void SaveFeedback()
    {
        Console.WriteLine($"Saving feedback: {Comment}.");
    }
}

public class NotificationService
{
    public void NotifySupport(Feedback feedback)
    {
        Console.WriteLine($"Notifying support about feedback: {feedback.Comment}.");
    }
}

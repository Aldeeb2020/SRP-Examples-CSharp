public class Feedback
{
    public string Comment { get; set; }

    public void SaveFeedback()
    {
        Console.WriteLine($"Saving feedback: {Comment}.");
    }

    public void NotifySupport()
    {
        Console.WriteLine($"Notifying support about feedback: {Comment}.");
    }
}

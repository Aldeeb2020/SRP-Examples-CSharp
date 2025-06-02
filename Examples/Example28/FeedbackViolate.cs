public class Feedback
{
    public string Comment { get; set; }

    public void SaveFeedback()
    {
        Console.WriteLine($"Saving feedback: {Comment}.");
    }

    public void AnalyzeFeedback()
    {
        Console.WriteLine($"Analyzing feedback: {Comment}.");
    }
}

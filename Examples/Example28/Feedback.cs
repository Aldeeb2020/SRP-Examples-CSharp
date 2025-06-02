public class Feedback
{
    public string Comment { get; set; }

    public void SaveFeedback()
    {
        Console.WriteLine($"Saving feedback: {Comment}.");
    }
}

public class FeedbackAnalyzer
{
    public void AnalyzeFeedback(Feedback feedback)
    {
        Console.WriteLine($"Analyzing feedback: {feedback.Comment}.");
    }
}

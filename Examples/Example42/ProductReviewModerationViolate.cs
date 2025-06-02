public class ProductReview
{
    public string Content { get; set; }

    public void SaveReview()
    {
        Console.WriteLine($"Saving review: {Content}.");
    }

    public void ModerateReview()
    {
        Console.WriteLine($"Moderating review: {Content}.");
    }
}

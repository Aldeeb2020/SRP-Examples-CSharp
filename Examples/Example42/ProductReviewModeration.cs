public class ProductReview
{
    public string Content { get; set; }

    public void SaveReview()
    {
        Console.WriteLine($"Saving review: {Content}.");
    }
}

public class ReviewModerator
{
    public void ModerateReview(ProductReview review)
    {
        Console.WriteLine($"Moderating review: {review.Content}.");
    }
}

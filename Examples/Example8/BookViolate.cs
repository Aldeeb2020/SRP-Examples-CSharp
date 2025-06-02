public class Book
{
    public string Title { get; set; }

    public void SaveBook()
    {
        Console.WriteLine($"Saving book {Title}.");
    }

    public void AddReview(string review)
    {
        Console.WriteLine($"Adding review for {Title}: {review}");
    }
}

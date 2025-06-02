public class Book
{
    public string Title { get; set; }

    public void SaveBook()
    {
        Console.WriteLine($"Saving book {Title}.");
    }
}

public class ReviewService
{
    public void AddReview(Book book, string review)
    {
        Console.WriteLine($"Adding review for {book.Title}: {review}");
    }
}

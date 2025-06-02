public class UserSession
{
    public string UserId { get; set; }

    public void StartSession()
    {
        Console.WriteLine($"Starting session for {UserId}.");
    }

    public void LogSession()
    {
        Console.WriteLine($"Logging session for {UserId}.");
    }
}

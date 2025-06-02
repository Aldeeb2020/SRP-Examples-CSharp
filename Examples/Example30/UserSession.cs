public class UserSession
{
    public string UserId { get; set; }

    public void StartSession()
    {
        Console.WriteLine($"Starting session for {UserId}.");
    }
}

public class SessionLogger
{
    public void LogSession(UserSession session)
    {
        Console.WriteLine($"Logging session for {session.UserId}.");
    }
}

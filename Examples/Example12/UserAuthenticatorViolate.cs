public class UserAuthenticator
{
    public bool Authenticate(string username, string password)
    {
        Console.WriteLine($"Authenticating {username}.");
        return true;
    }

    public void LogAuthentication(string username)
    {
        Console.WriteLine($"Logging authentication for {username}.");
    }
}

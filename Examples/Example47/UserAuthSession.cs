public class UserAuthenticator
{
    public string Username { get; set; }

    public bool Authenticate(string password)
    {
        Console.WriteLine($"Authenticating {Username}.");
        return true;
    }
}

public class SessionManager
{
    public void ManageSession(UserAuthenticator user)
    {
        Console.WriteLine($"Managing session for {user.Username}.");
    }
}

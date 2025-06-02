public class User
{
    public string Username { get; set; }

    public bool Authenticate(string password)
    {
        Console.WriteLine($"Authenticating {Username}.");
        return true;
    }

    public void ManageSession()
    {
        Console.WriteLine($"Managing session for {Username}.");
    }
}

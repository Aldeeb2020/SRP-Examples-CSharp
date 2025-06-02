public class User
{
    public string Username { get; set; }

    public void Register()
    {
        Console.WriteLine($"Registering user {Username}.");
    }

    public bool ValidateUser()
    {
        Console.WriteLine($"Validating user {Username}.");
        return true;
    }
}

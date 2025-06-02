public class UserRegistration
{
    public string Username { get; set; }

    public void Register()
    {
        Console.WriteLine($"Registering user {Username}.");
    }
}

public class UserValidator
{
    public bool ValidateUser(UserRegistration user)
    {
        Console.WriteLine($"Validating user {user.Username}.");
        return true;
    }
}

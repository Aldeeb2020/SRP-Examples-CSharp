public class UserManager
{
    public void CreateUser(string username, string email)
    {
        Console.WriteLine($"Saving user {username} with email {email} to database.");
    }
}

public class EmailService
{
    public void SendWelcomeEmail(string email)
    {
        Console.WriteLine($"Sending welcome email to {email}.");
    }
}

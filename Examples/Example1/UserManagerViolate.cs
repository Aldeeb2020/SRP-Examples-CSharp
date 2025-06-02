public class UserManager
{
    public void CreateUser(string username, string email)
    {
        // Save user to database
        Console.WriteLine($"Saving user {username} with email {email} to database.");
        
        // Send welcome email
        Console.WriteLine($"Sending welcome email to {email}.");
    }
}

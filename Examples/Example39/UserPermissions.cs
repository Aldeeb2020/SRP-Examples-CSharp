public class User
{
    public string Role { get; set; }

    public void SetPermissions()
    {
        Console.WriteLine($"Setting permissions for role {Role}.");
    }
}

public class PermissionLogger
{
    public void LogPermissions(User user)
    {
        Console.WriteLine($"Logging permissions for role {user.Role}.");
    }
}

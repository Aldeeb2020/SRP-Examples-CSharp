public class User
{
    public string Role { get; set; }

    public void SetPermissions()
    {
        Console.WriteLine($"Setting permissions for role {Role}.");
    }

    public void LogPermissions()
    {
        Console.WriteLine($"Logging permissions for role {Role}.");
    }
}

public class UserProfile
{
    public string Name { get; set; }

    public void UpdateProfile()
    {
        Console.WriteLine($"Updating profile for {Name}.");
    }

    public void ExportProfile()
    {
        Console.WriteLine($"Exporting profile for {Name}.");
    }
}

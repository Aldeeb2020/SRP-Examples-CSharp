public class UserProfile
{
    public string Name { get; set; }

    public void UpdateProfile()
    {
        Console.WriteLine($"Updating profile for {Name}.");
    }
}

public class ProfileExporter
{
    public void ExportProfile(UserProfile profile)
    {
        Console.WriteLine($"Exporting profile for {profile.Name}.");
    }
}

public class UserProfile
{
    public string Name { get; set; }

    public void SaveProfile()
    {
        Console.WriteLine($"Saving profile for {Name}.");
    }
}

public class BackupService
{
    public void BackupProfile(UserProfile profile)
    {
        Console.WriteLine($"Backing up profile for {profile.Name}.");
    }
}

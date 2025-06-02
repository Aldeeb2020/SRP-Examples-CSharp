public class UserProfile
{
    public string Name { get; set; }

    public void SaveProfile()
    {
        Console.WriteLine($"Saving profile for {Name}.");
    }

    public void BackupProfile()
    {
        Console.WriteLine($"Backing up profile for {Name}.");
    }
}

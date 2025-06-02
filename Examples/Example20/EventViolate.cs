public class Event
{
    public string Name { get; set; }

    public void CreateEvent()
    {
        Console.WriteLine($"Creating event {Name}.");
    }

    public void LogEvent()
    {
        Console.WriteLine($"Logging event {Name}.");
    }
}

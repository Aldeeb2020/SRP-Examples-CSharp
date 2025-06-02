public class Event
{
    public string Name { get; set; }

    public void CreateEvent()
    {
        Console.WriteLine($"Creating event {Name}.");
    }
}

public class EventLogger
{
    public void LogEvent(Event evt)
    {
        Console.WriteLine($"Logging event {evt.Name}.");
    }
}

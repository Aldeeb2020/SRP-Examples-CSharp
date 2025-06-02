public class SupportAgent
{
    public void HandleTicket(string issue)
    {
        Console.WriteLine($"Handling ticket: {issue}.");
    }
}

public class TicketLogger
{
    public void LogTicket(string issue)
    {
        Console.WriteLine($"Logging ticket: {issue}.");
    }
}

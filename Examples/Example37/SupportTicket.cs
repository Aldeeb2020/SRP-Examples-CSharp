public class SupportTicket
{
    public string Issue { get; set; }

    public void ProcessTicket()
    {
        Console.WriteLine($"Processing ticket: {Issue}.");
    }
}

public class EmailService
{
    public void SendEmail(SupportTicket ticket)
    {
        Console.WriteLine($"Sending email for ticket: {ticket.Issue}.");
    }
}

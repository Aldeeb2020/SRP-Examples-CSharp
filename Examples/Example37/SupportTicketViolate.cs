public class SupportTicket
{
    public string Issue { get; set; }

    public void ProcessTicket()
    {
        Console.WriteLine($"Processing ticket: {Issue}.");
    }

    public void SendEmail()
    {
        Console.WriteLine($"Sending email for ticket: {Issue}.");
    }
}

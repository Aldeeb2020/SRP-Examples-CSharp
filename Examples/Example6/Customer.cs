public class Customer
{
    public string Name { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer {Name}.");
    }

    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending notification to {Name}: {message}");
    }
}

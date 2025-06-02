public class Customer
{
    public string Name { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer {Name}.");
    }
}

public class AnalyticsService
{
    public void AnalyzeBehavior(Customer customer)
    {
        Console.WriteLine($"Analyzing behavior for {customer.Name}.");
    }
}

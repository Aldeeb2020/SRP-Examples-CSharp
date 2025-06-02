public class Customer
{
    public string Name { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer {Name}.");
    }
}

public class ReportGenerator
{
    public void GenerateReport(Customer customer)
    {
        Console.WriteLine($"Generating report for {customer.Name}.");
    }
}

public class Customer
{
    public string Name { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer {Name}.");
    }

    public void GenerateReport()
    {
        Console.WriteLine($"Generating report for {Name}.");
    }
}

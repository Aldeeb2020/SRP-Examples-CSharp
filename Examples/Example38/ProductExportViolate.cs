public class Product
{
    public string Name { get; set; }

    public void SaveProduct()
    {
        Console.WriteLine($"Saving product {Name}.");
    }

    public void ExportToCsv()
    {
        Console.WriteLine($"Exporting product {Name} to CSV.");
    }
}

public class Product
{
    public string Name { get; set; }

    public void SaveProduct()
    {
        Console.WriteLine($"Saving product {Name}.");
    }
}

public class CsvExporter
{
    public void ExportToCsv(Product product)
    {
        Console.WriteLine($"Exporting product {product.Name} to CSV.");
    }
}

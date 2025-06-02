public class ProductCatalog
{
    public List<string> Products { get; set; } = new List<string>();

    public void AddProduct(string product)
    {
        Products.Add(product);
        Console.WriteLine($"Added {product}.");
    }

    public decimal CalculatePrice(string product)
    {
        Console.WriteLine($"Calculating price for {product}.");
        return 100m;
    }
}

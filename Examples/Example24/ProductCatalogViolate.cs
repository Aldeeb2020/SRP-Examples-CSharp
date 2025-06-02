public class ProductCatalog
{
    public List<string> Products { get; set; } = new List<string>();

    public void AddProduct(string product)
    {
        Products.Add(product);
        Console.WriteLine($"Added {product}.");
    }

    public string SearchProduct(string query)
    {
        Console.WriteLine($"Searching for {query}.");
        return Products.FirstOrDefault(p => p.Contains(query));
    }
}

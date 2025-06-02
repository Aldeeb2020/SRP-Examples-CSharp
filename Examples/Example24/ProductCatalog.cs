public class ProductCatalog
{
    public List<string> Products { get; set; } = new List<string>();

    public void AddProduct(string product)
    {
        Products.Add(product);
        Console.WriteLine($"Added {product}.");
    }
}

public class SearchService
{
    public string SearchProduct(ProductCatalog catalog, string query)
    {
        Console.WriteLine($"Searching for {query}.");
        return catalog.Products.FirstOrDefault(p => p.Contains(query));
    }
}

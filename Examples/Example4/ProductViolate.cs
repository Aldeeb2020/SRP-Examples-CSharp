public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public void SaveProduct()
    {
        Console.WriteLine($"Saving product {Name}.");
    }

    public decimal ApplyDiscount(decimal discountPercentage)
    {
        return Price * (1 - discountPercentage);
    }
}

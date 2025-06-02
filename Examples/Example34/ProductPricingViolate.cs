public class Product
{
    public decimal Price { get; set; }

    public void SetPrice(decimal price)
    {
        Price = price;
        Console.WriteLine($"Set price to {Price}.");
    }

    public decimal CalculateTax()
    {
        Console.WriteLine($"Calculating tax for price {Price}.");
        return Price * 0.2m;
    }
}

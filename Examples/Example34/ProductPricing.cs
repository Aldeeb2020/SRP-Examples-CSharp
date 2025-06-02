public class Product
{
    public decimal Price { get; set; }

    public void SetPrice(decimal price)
    {
        Price = price;
        Console.WriteLine($"Set price to {Price}.");
    }
}

public class TaxCalculator
{
    public decimal CalculateTax(Product product)
    {
        Console.WriteLine($"Calculating tax for price {product.Price}.");
        return product.Price * 0.2m;
    }
}

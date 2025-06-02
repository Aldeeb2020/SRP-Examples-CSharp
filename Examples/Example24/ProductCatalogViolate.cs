// هذا الكلاس مسؤول عن أكثر من شيء (خرق SRP)
public class ProductCatalog
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }

    public List<Product> GetAllProducts()
    {
        return products;
    }

    // هذه وظيفة مختلفة: تنسيق وطباعة
    public void PrintProducts()
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}

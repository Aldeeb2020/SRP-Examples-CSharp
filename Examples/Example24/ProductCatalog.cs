// مسؤول فقط عن إدارة الكتالوج: إضافة وحذف المنتجات
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
}

// كلاس منفصل لتنسيق طباعة المنتجات (مسؤولية مختلفة)
public class ProductPrinter
{
    public void PrintProducts(List<Product> products)
    {
        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}

}

public class ShoppingCart
{
    public List<string> Items { get; set; } = new List<string>();

    public void AddItem(string item)
    {
        Items.Add(item);
        Console.WriteLine($"Added {item} to cart.");
    }

    public decimal CalculateTax()
    {
        return Items.Count * 0.1m;
    }
}

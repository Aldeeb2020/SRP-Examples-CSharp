public class OrderProcessor
{
    public void ProcessOrder(int orderId)
    {
        Console.WriteLine($"Processing order {orderId}.");
    }

    public void UpdateInventory(int productId)
    {
        Console.WriteLine($"Updating inventory for product {productId}.");
    }
}

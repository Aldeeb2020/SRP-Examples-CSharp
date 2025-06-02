public class Order
{
    public decimal Amount { get; set; }

    public void ApplyDiscount(decimal percentage)
    {
        Amount *= (1 - percentage);
        Console.WriteLine($"Applied discount to order: {Amount}.");
    }
}

public class OrderValidator
{
    public bool ValidateOrder(Order order)
    {
        Console.WriteLine($"Validating order with amount {order.Amount}.");
        return true;
    }
}

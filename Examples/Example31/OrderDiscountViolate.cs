public class Order
{
    public decimal Amount { get; set; }

    public void ApplyDiscount(decimal percentage)
    {
        Amount *= (1 - percentage);
        Console.WriteLine($"Applied discount to order: {Amount}.");
    }

    public bool ValidateOrder()
    {
        Console.WriteLine($"Validating order with amount {Amount}.");
        return true;
    }
}

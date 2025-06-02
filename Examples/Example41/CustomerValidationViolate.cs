public class Customer
{
    public string Email { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer with email {Email}.");
    }

    public bool ValidateEmail()
    {
        Console.WriteLine($"Validating email {Email}.");
        return Email.Contains("@");
    }
}

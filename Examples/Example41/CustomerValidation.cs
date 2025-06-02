public class Customer
{
    public string Email { get; set; }

    public void SaveCustomer()
    {
        Console.WriteLine($"Saving customer with email {Email}.");
    }
}

public class EmailValidator
{
    public bool ValidateEmail(Customer customer)
    {
        Console.WriteLine($"Validating email {customer.Email}.");
        return customer.Email.Contains("@");
    }
}

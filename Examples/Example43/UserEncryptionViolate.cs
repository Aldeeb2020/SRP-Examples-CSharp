public class User
{
    public string Data { get; set; }

    public void SaveUser()
    {
        Console.WriteLine($"Saving user data: {Data}.");
    }

    public void EncryptData()
    {
        Console.WriteLine($"Encrypting user data: {Data}.");
    }
}

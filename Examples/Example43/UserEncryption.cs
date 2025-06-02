public class User
{
    public string Data { get; set; }

    public void SaveUser()
    {
        Console.WriteLine($"Saving user data: {Data}.");
    }
}

public class DataEncrypter
{
    public void EncryptData(User user)
    {
        Console.WriteLine($"Encrypting user data: {user.Data}.");
    }
}

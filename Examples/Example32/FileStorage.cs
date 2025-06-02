public class FileStorage
{
    public void SaveFile(string path)
    {
        Console.WriteLine($"Saving file to {path}.");
    }
}

public class FileEncrypter
{
    public void EncryptFile(string path)
    {
        Console.WriteLine($"Encrypting file at {path}.");
    }
}

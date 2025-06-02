public class FileManager
{
    public void SaveFile(string path)
    {
        Console.WriteLine($"Saving file to {path}.");
    }
}

public class FileCompressor
{
    public void CompressFile(string path)
    {
        Console.WriteLine($"Compressing file at {path}.");
    }
}

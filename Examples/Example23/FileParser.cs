public class FileParser
{
    public void ParseFile(string path)
    {
        Console.WriteLine($"Parsing file {path}.");
    }
}

public class FileValidator
{
    public bool ValidateFile(string path)
    {
        Console.WriteLine($"Validating file {path}.");
        return true;
    }
}

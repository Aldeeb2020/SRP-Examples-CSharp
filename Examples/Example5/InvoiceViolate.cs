public class Invoice
{
    public int Id { get; set; }
    public decimal Amount { get; set; }

    public void GenerateInvoice()
    {
        Console.WriteLine($"Generating invoice {Id}.");
    }

    public void ExportToPdf()
    {
        Console.WriteLine($"Exporting invoice {Id} to PDF.");
    }
}

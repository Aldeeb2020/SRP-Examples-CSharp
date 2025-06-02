public class Invoice
{
    public int Id { get; set; }
    public decimal Amount { get; set; }

    public void GenerateInvoice()
    {
        Console.WriteLine($"Generating invoice {Id}.");
    }
}

public class PdfExporter
{
    public void ExportToPdf(Invoice invoice)
    {
        Console.WriteLine($"Exporting invoice {invoice.Id} to PDF.");
    }
}

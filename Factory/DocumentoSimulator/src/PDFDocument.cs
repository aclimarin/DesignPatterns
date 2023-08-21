namespace src;

//this is a concrete product
public class PDFDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("Close PDF Document");
    }

    public void Delete()
    {
        Console.WriteLine("Delete PDF Document");
    }

    public void Open()
    {
        Console.WriteLine("Open PDF Document");
    }

    public void Save()
    {
        Console.WriteLine("Save PDF Document");
    }
}
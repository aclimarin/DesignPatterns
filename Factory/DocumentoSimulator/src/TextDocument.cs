namespace src;

//this is a concrete product
public class TextDocument : IDocument
{
    public void Close()
    {
        Console.WriteLine("Close Text Document");
    }

    public void Delete()
    {
        Console.WriteLine("Delete Text Document");
    }

    public void Open()
    {
        Console.WriteLine("Open Text Document");
    }

    public void Save()
    {
        Console.WriteLine("Save Text Document");
    }
}
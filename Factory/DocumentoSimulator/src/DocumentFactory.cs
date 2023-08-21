namespace src;

//this is the factory concrete class
public class DocumentFactory : IDocumentFactory
{
    public IDocument MakePDF()
    {
        return new PDFDocument();
    }

    public IDocument MakeText()
    {
        return new TextDocument();
    }
}
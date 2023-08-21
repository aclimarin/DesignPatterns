namespace src;

//this is the factory interface
public interface IDocumentFactory
{
    IDocument MakeText();
    IDocument MakePDF();
}
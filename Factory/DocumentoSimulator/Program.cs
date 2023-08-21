using src;

internal class Program
{
    private static void Main(string[] args)
    {
        IDocumentFactory documentFactory = new DocumentFactory();

        var pdf = documentFactory.MakePDF();
        var text = documentFactory.MakeText();

        pdf.Open();
        pdf.Save();
        pdf.Close();
        pdf.Delete();
        Console.WriteLine();
        text.Open();
        text.Save();
        text.Close();
        text.Delete();
    }
}
namespace src;

//This is the Product Interface
public interface IDocument
{
    void Open();
    void Close();
    void Save();
    void Delete();
}
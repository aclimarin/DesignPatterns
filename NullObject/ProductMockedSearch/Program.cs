using src;

internal class Program
{
    private static void Main(string[] args)
    {
        MockProductDB productDB = new MockProductDB();

        var productName = "Eraser";
        Product product = productDB.GetProductByName(productName);
        product.Sell();
    }
}
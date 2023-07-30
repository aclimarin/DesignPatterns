namespace src;

public class MockProductDB
{
    private List<Product> products;

    public MockProductDB()
    {
        // Initialize a mocked list of products
        products = new List<Product>
        {
            new Product { Name = "Notepad", Price = 5 },
            new Product { Name = "Pen", Price = 3 }
        };
    }

    public Product GetProductByName(string name)
    {
        Product product = products.Find(p => p.Name.Equals(name));        
        return product ?? Product.NULL;
    }
}
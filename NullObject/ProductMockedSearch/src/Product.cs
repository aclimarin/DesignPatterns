namespace src;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public static Product NULL { get; } = new NullProduct();

    public virtual bool InStock()
    {
        /* ... */
        return true;
    }

    public virtual void Sell()
    {
        Console.WriteLine($"The product '{Name}' has been sold.");
    }

    private class NullProduct : Product
    {
        public override bool InStock()
        {
            return false;
        }

        public override void Sell()
        {
            Console.WriteLine($"Nothing happens becouse product is null.");
        }
    }
}
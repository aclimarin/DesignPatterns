using src;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shopping Cart Simulator!");
        Console.WriteLine("=======================================");

        // For this example, let's assume the customer is a premium customer
        IDiscountStrategy premiumCustomerDiscount = new PremiumCustomerDiscount();
        ShoppingCart shoppingCart = new ShoppingCart(premiumCustomerDiscount);

        // Simulate the cart total
        decimal cartTotal = 100.0m;

        // Calculate the total with the selected discount strategy
        decimal totalAfterDiscount = shoppingCart.CalculateTotal(cartTotal);

        Console.WriteLine($"Cart Total: ${cartTotal}");
        Console.WriteLine($"Total after Discount: ${totalAfterDiscount}");
    }
}
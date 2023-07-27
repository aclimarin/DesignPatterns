namespace src;

/*
* Context class that uses the IDiscountStrategy
*/

public class ShoppingCart
{
    private readonly IDiscountStrategy _discountStrategy;

    public ShoppingCart(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public decimal CalculateTotal(decimal cartTotal)
    {
        return _discountStrategy.ApplyDiscount(cartTotal);
    }
}
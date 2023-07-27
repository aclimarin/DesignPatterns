namespace src;

/*
* The concrete class to implement Discount behavior for a Premium Customer
*/

public class PremiumCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        // 10% discount for premium customers
        return amount * 0.9m;
    }
}
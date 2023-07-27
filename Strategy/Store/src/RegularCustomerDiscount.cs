namespace src;

/*
* The concrete class to implement Discount behavior for a Regular Customer
*/

public class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount)
    {
        return amount;
    }
}
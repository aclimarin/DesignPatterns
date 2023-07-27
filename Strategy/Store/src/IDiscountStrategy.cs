namespace src;

/*
* The strategy interface that can have multiple behaviors
*/

public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}
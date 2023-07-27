namespace src;

/*
* In Template Method pattern, the template is an abstract class
* representing a common structure of an algorithm but with some steps
* that can have diferent implementations
*/

public abstract class BeverageVendingMachineTemplate
{
    public void DispenseBeverage()
    {
        SelectBeverage();
        ProccessPayment();
        PrepareBeverage();
        Dispense();
    }

    protected void SelectBeverage()
    {
        Console.WriteLine("Please select your beverage: (1) Coffee or (2) Soda");
    }

    protected void ProccessPayment()
    {
        Console.Write("Please insert your payment (in cents): ");
        int payment = int.Parse(Console.ReadLine());
        Console.WriteLine($"Payment received: {payment} cents.");
    }

    protected abstract void PrepareBeverage();

    protected void Dispense()
    {
        Console.WriteLine("Your beverage is ready. Enjoy!");
    }
}
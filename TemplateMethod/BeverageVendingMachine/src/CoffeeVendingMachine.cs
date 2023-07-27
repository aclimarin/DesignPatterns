namespace src;

/*
* The concrete class implementing a specific behavior defined in the template
*/
public class CoffeeVendingMachine : BeverageVendingMachineTemplate
{
    protected override void PrepareBeverage()
    {
        Console.WriteLine("Grinding coffee beans and brewing coffee.");
    }
}
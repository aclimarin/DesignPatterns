namespace src;

/*
* The concrete class implementing a specific behavior defined in the template
*/
public class SodaVendingMachine : BeverageVendingMachineTemplate
{
    protected override void PrepareBeverage()
    {
        Console.WriteLine("Adding carbonation and mixing syrup.");
    }
}
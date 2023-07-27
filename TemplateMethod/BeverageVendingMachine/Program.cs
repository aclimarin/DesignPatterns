using src;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Beverage Vending Machine!");
            Console.WriteLine("=======================================");
            Console.WriteLine("Select your beverage: (1) Coffee, (2) Soda, or (0) Exit");

            string input = Console.ReadLine();
            if (input == "0")
                break;

            BeverageVendingMachineTemplate vendingMachine;
            if (input == "1")
                vendingMachine = new CoffeeVendingMachine();
            else if (input == "2")
                vendingMachine = new SodaVendingMachine();
            else
            {
                Console.WriteLine("Invalid input. Please try again.");
                continue;
            }

            Console.WriteLine();
            vendingMachine.DispenseBeverage();
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the Beverage Vending Machine. Have a great day!");
    }
}
using src;
using src.Commands;

internal class Program
{
    private static void Main(string[] args)
    {
        LightBulb lightBulb = new LightBulb();
        RemoteControl invoker = new RemoteControl();

        while (true)
        {
            Console.WriteLine("Commands: T (Toggle) / R (Red) / B (Blue) / G (Green) / U (undo) / QUIT");
            string input = Console.ReadLine().Trim().ToUpper();

            ICommand command = null;
            switch (input.ToUpper())
            {
                case "T":
                    command = new ToggleCommand(lightBulb);
                    break;
                case "R":
                    command = new SetColorCommand(lightBulb, "RED");
                    break;
                case "B":
                    command = new SetColorCommand(lightBulb, "BLUE");
                    break;
                case "G":
                    command = new SetColorCommand(lightBulb, "GREEN");
                    break;
                case "U":
                    invoker.UndoLastCommand();
                    continue;
                case "QUIT":
                    return;
                default:
                    Console.WriteLine("Invalid command.");
                    continue;
            }

            if (command != null)
            {
                invoker.ExecuteCommand(command);
                lightBulb.PrintStatus();
            }
        }
    }
}
using src;

class Program
{
    static void Main(string[] args)
    {
        var logger = Logger.Instance;

        logger.Log("First log for singleton pattern implementation");
        logger.Log("Second log for my singleton pattern. Still using 'logger' variable");

        var logger2 = Logger.Instance;
        logger2.Log("The third log now using logger2");
        Console.WriteLine("");

        if (logger == logger2)
        {
            Console.WriteLine("Both logger and logger2 point to the same instance.");
            Console.WriteLine("");
            Console.WriteLine("See te logs bellow called from 'logger':");
            logger.PrintLogs();

            Console.WriteLine("");
            Console.WriteLine("See te logs bellow called from 'logger2':");
            logger2.PrintLogs();
        }
        else
        {
            Console.WriteLine("Error: 'logger' and 'logger2' are different instances.");
        }
    }
}

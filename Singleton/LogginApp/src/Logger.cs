namespace src;

public class Logger
{
    private static Logger _instance = null;
    private const string _logFilePath = "log.txt";

    /// <summary>
    /// The private constructor makes impossible to instanciate
    /// withount calling the Instance staticproperty. This way
    /// there will aways be only one instance of Logging
    /// </summary>
    private Logger( ) { }

    public static Logger Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Logger();

            return _instance;
        }
    }

    public void Log(string message)
    {
        Console.WriteLine($"LOG REGISTERED: { message }");
        WriteToFile(message);
    }

    public void PrintLogs()
    {
        try
        {
            var lines = File.ReadAllLines(_logFilePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"File '{ _logFilePath }' not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }

    private void WriteToFile(string message)
    {
        try
        {
            using(StreamWriter writer = File.AppendText(_logFilePath))
            {
                writer.WriteLine($"{ DateTime.Now } - { message }");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Error writing log file: { ex.Message }");
        }
    }
}
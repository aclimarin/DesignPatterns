namespace src;

public class GameManager
{
    //By making the variables static all instances will share its value
    private static int _score = 0;
    private static int _level = 1;

    public int Score
    {
        get { return _score; }
        set { _score = value; }
    }

    public int Level
    {
        get { return _level; }
        set { _level = value; }
    }

    public void DisplayGameState()
    {
        Console.WriteLine($"Current Level: { _level }");
        Console.WriteLine($"Current Score: { _score }");
    }

}
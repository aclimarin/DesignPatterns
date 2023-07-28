using src;

class Program
{
    static void Main(string[] args)
    {
        GameManager gameManager1 = new GameManager();
        gameManager1.Score = 100;
        gameManager1.Level = 5;
        gameManager1.DisplayGameState();

        GameManager gameManager2 = new GameManager();
        gameManager2.DisplayGameState();

        // Change the shared state through either game manager
        gameManager1.Level = 10;
        gameManager2.Score = 200;

        // The shared state has been updated for both game managers
        gameManager1.DisplayGameState();
        gameManager2.DisplayGameState();
    }
}
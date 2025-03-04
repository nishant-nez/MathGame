namespace MathGame
{
    internal class Menu
    {
        GameEngine gameEngine = new GameEngine();
        internal void ShowMenu(string name)
        {
            var date = DateTime.UtcNow; 
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself");
            Console.WriteLine("Press any key to show menu");
            Console.ReadLine();
            Console.WriteLine("\n");

            var isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division
R - Random
Q - Quit the program");
                Console.WriteLine("---------------------------------------------");

                var gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.PlayGame(GameType.Addition, "Addition game");
                        break;
                    case "s":
                        gameEngine.PlayGame(GameType.Subtraction, "Subtraction game");
                        break;
                    case "m":
                        gameEngine.PlayGame(GameType.Multiplication, "Multiplication game");
                        break;
                    case "d":
                        gameEngine.PlayGame(GameType.Division, "Division game");
                        break;
                    case "r":
                        gameEngine.PlayGame(GameType.Random, "Random game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);
        }
    }
}

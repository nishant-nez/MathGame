using MathGame.Models;
using System;
namespace MathGame
{
    internal class Helpers
    {
        static List<Game> games = new List<Game>();
        internal static void GetGames()
        {
            var gamesToPrint = games.Where(x => x.Date > new DateTime(2024, 12, 12)).OrderByDescending(x => x.Score); // extension method of LINQ
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            if (gamesToPrint.Count() != 0)
            {
                foreach (var game in games)
                {
                    Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts in {game.Difficulty} difficulty.");
                }
            } else
            {
                Console.WriteLine("No games played yet");
            }
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }


        internal static void AddToHistory(int gameScore, GameType gameType, GameDifficulty difficulty)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = gameScore,
                Type = gameType,
                Difficulty = difficulty
            });
        }

        internal static int[] GetDivisionNumbers(GameDifficulty difficulty)
        {
            int upperBound = 99;
            if (difficulty == GameDifficulty.Medium)
            {
                upperBound = 199;
            }
            else if (difficulty == GameDifficulty.Hard)
            {
                upperBound = 599;
            }
            var random = new Random();
            var firstNumber = random.Next(1, upperBound);
            var secondNumber = random.Next(1, upperBound);

            var result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = random.Next(1, upperBound);
                secondNumber = random.Next(1, upperBound);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static string? ValidateResult(string? input)
        {
            while (string.IsNullOrEmpty(input) || !Int32.TryParse(input, out _))
            {
                Console.WriteLine("Please enter a valid number");
                input = Console.ReadLine();
            }
            return input;
        }

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();
            
            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty!");
                Console.WriteLine("Please type your name");
                name = Console.ReadLine();
            }
            return name;
        }

        internal static GameDifficulty ChooseGameDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Please choose a difficulty level (easy, medium, hard): ");
            string difficultyInput = Console.ReadLine();

            while (string.IsNullOrEmpty(difficultyInput) || (difficultyInput.ToLower() != "easy" && difficultyInput.ToLower() != "medium" && difficultyInput.ToLower() != "hard"))
            {
                Console.WriteLine("Please enter a valid difficulty level (easy, medium, hard): ");
                difficultyInput = Console.ReadLine();
            }
            GameDifficulty difficulty;
            if (difficultyInput.ToLower() == "easy") difficulty = GameDifficulty.Easy;
            else if (difficultyInput.ToLower() == "medium") difficulty = GameDifficulty.Medium;
            else difficulty = GameDifficulty.Hard;

            return difficulty;
        }
    }
}

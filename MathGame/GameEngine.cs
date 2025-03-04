using System;
using System.Timers;

namespace MathGame
{
    internal class GameEngine
    {
        private static readonly Random _random = new Random();

        internal void PlayGame(GameType gameType, string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();
            var score = 0;
            DateTime start = DateTime.Now;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                
                var (firstNumber, secondNumber) = GenerateNumbers(difficulty, gameType);
                string operationSymbol = GetOperationSymbol(gameType);
                int correctAnswer = CalculateAnswer(firstNumber, secondNumber, operationSymbol);
                
                Console.WriteLine($"{firstNumber} {operationSymbol} {secondNumber}");
                var result = Helpers.ValidateResult(Console.ReadLine());
                
                if (int.Parse(result) == correctAnswer)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                }
                Console.ReadLine();
            }
            
            string duration = (DateTime.Now - start).TotalSeconds.ToString("#.#");
            Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, gameType, difficulty, duration);
        }

        private (int, int) GenerateNumbers(GameDifficulty difficulty, GameType gameType)
        {
            var random = new Random();
            int upperBound = difficulty switch
            {
                GameDifficulty.Medium => 59,
                GameDifficulty.Hard => 199,
                _ => 9
            };
            
            int first = random.Next(1, upperBound);
            int second = gameType == GameType.Division ? GetValidDivisor(first, upperBound) : random.Next(1, upperBound);
            return (first, second);
        }
        
        private int GetValidDivisor(int numerator, int max)
        {
            var random = new Random();
            int divisor;
            do
            {
                divisor = random.Next(1, max);
            } while (numerator % divisor != 0);
            return divisor;
        }
        
        private string GetOperationSymbol(GameType gameType) => gameType switch
        {
            GameType.Random => GetOperationSymbol(GetRandomGameType()),
            GameType.Addition => "+",
            GameType.Subtraction => "-",
            GameType.Multiplication => "*",
            GameType.Division => "/",
            _ => "?"
        };
        
        private int CalculateAnswer(int first, int second, string operationSymbol) => operationSymbol switch
        {
            "+" => first + second,
            "-" => first - second,
            "*" => first * second,
            "/" => first / second,
            _ => 0
        };

        private GameType GetRandomGameType() => (GameType)_random.Next(0, 4);
    }
}

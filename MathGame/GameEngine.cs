namespace MathGame
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers(difficulty);
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, GameType.Division, difficulty);
        }

        internal void MultiplicationGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int upperBound = 9;
                if (difficulty == GameDifficulty.Medium)
                {
                    upperBound = 59;
                }
                else if (difficulty == GameDifficulty.Hard)
                {
                    upperBound = 199;
                }

                firstNumber = random.Next(1, upperBound);
                secondNumber = random.Next(1, upperBound);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, GameType.Multiplication, difficulty);
        }

        internal void SubtractionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int upperBound = 9;
                if (difficulty == GameDifficulty.Medium)
                {
                    upperBound = 59;
                }
                else if (difficulty == GameDifficulty.Hard)
                {
                    upperBound = 199;
                }

                firstNumber = random.Next(1, upperBound);
                secondNumber = random.Next(1, upperBound);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            }

            Helpers.AddToHistory(score, GameType.Subtraction, difficulty);
        }

        internal void AdditionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                int upperBound = 9;
                if (difficulty == GameDifficulty.Medium)
                {
                    upperBound = 59;
                }
                else if (difficulty == GameDifficulty.Hard)
                {
                    upperBound = 199;
                }

                firstNumber = random.Next(1, upperBound);
                secondNumber = random.Next(1, upperBound);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition, difficulty);
        }

    }
}

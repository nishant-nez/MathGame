using System.Timers;

namespace MathGame
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var score = 0;
            DateTime start = DateTime.Now;
            string duration = "0";

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

                if (i == 4)
                {
                    DateTime end = DateTime.Now;
                    duration = (end - start).TotalSeconds.ToString("#.#");
                    Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
                }
            }

            Helpers.AddToHistory(score, GameType.Division, difficulty, duration);
        }

        internal void MultiplicationGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            DateTime start = DateTime.Now;
            string duration = "0";

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

                if (i == 4)
                {
                    DateTime end = DateTime.Now;
                    duration = (end - start).TotalSeconds.ToString("#.#");
                    Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
                }
            }

            Helpers.AddToHistory(score, GameType.Multiplication, difficulty, duration);
        }

        internal void SubtractionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            DateTime start = DateTime.Now;
            string duration = "0";

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

                if (i == 4)
                {
                    DateTime end = DateTime.Now;
                    duration = (end - start).TotalSeconds.ToString("#.#");
                    Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
                }
            }

            Helpers.AddToHistory(score, GameType.Subtraction, difficulty, duration);
        }

        internal void AdditionGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            DateTime start = DateTime.Now;
            string duration = "0";

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
                    DateTime end = DateTime.Now;
                    duration = (end - start).TotalSeconds.ToString("#.#");
                    Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition, difficulty, duration);
        }

        internal void RandomGame(string message)
        {
            GameDifficulty difficulty = Helpers.ChooseGameDifficulty();

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            DateTime start = DateTime.Now;
            string duration = "0";

            for (int i = 0; i < 5; i++)
            {                
                if (random.Next(0, 4) == 0)
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
                }
                else if (random.Next(0, 4) == 1)
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
                }
                else if (random.Next(0, 4) == 2)
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
                }
                else if (random.Next(0, 4) == 3)
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
                }

            }

            DateTime end = DateTime.Now;
            duration = (end - start).TotalSeconds.ToString("#.#");
            Console.WriteLine($"Game over. Your final score is {score}. You took {duration} seconds. Press any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Random, difficulty, duration);
        }

    }
}

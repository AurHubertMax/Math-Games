using System.Diagnostics;
using Math_Games.Models;

namespace Math_Games
{
    internal class GameEngine
    {
        internal void ModulusGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;
            var stopwatch = new Stopwatch();

            Difficulty game_difficulty = (Difficulty)Helpers.GetGameDifficulty();
            int multiplier = game_difficulty == Difficulty.Easy ? 1 : game_difficulty == Difficulty.Medium ? 10 : 100;

            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Modulus selected");
                first_number = random.Next(1, 9);
                second_number = random.Next(1, 9);
                Console.WriteLine($"{first_number} % {second_number} : ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == first_number % second_number)
                {
                    score++;
                    Console.WriteLine("Correct! Type any key for the next question");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question");
                    Console.ReadLine();
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Modulus, game_difficulty, stopwatch.Elapsed);
        }

        internal void DivisionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;
            var stopwatch = new Stopwatch();

            Difficulty game_difficulty = (Difficulty)Helpers.GetGameDifficulty();
            int multiplier = game_difficulty == Difficulty.Easy ? 1 : game_difficulty == Difficulty.Medium ? 10 : 100;

            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division selected");
                var division_numbers = Helpers.GetDivisionNumbers(multiplier);
                first_number = division_numbers[0];
                second_number = division_numbers[1];

                Console.WriteLine($"{first_number} / {second_number}: ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == first_number / second_number)
                {
                    score++;
                    Console.WriteLine("Correct! Type any key for the next question");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question");
                    Console.ReadLine();
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Division, game_difficulty, stopwatch.Elapsed);
        }

        internal void MultiplicationGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;
            var stopwatch = new Stopwatch();   

            Difficulty game_difficulty = (Difficulty)Helpers.GetGameDifficulty();
            int multiplier = game_difficulty == Difficulty.Easy ? 1 : game_difficulty == Difficulty.Medium ? 10 : 100;

            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication selected");
                first_number = random.Next(1 * multiplier, 9 * multiplier);
                second_number = random.Next(1 * multiplier, 9 * multiplier);
                Console.WriteLine($"{first_number} * {second_number} : ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == first_number * second_number)
                {
                    score++;
                    Console.WriteLine("Correct! Type any key for the next question");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question");
                    Console.ReadLine();
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication, game_difficulty, stopwatch.Elapsed);
        }

        internal void SubtractionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;
            var stopwatch = new Stopwatch();

            Difficulty game_difficulty = (Difficulty)Helpers.GetGameDifficulty();
            int multiplier = game_difficulty == Difficulty.Easy ? 1 : game_difficulty == Difficulty.Medium ? 100 : 1000;

            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction selected");
                first_number = random.Next(1 * multiplier, 9 * multiplier);
                second_number = random.Next(1 * multiplier, 9 * multiplier);
                Console.WriteLine($"{first_number} - {second_number} : ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == first_number - second_number)
                {
                    score++;
                    Console.WriteLine("Correct! Type any key for the next question");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question");
                    Console.ReadLine();
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Subtraction, game_difficulty, stopwatch.Elapsed);
        }

        internal void AdditionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;
            var stopwatch = new Stopwatch();

            Difficulty game_difficulty = (Difficulty)Helpers.GetGameDifficulty();
            int multiplier = game_difficulty == Difficulty.Easy ? 1 : game_difficulty == Difficulty.Medium ? 100 : 1000;

            stopwatch.Start();
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition selected");
                first_number = random.Next(1 * multiplier, 9 * multiplier);
                second_number = random.Next(1 * multiplier, 9 * multiplier);
                Console.WriteLine($"{first_number} + {second_number} : ");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == first_number + second_number)
                {
                    score++;
                    Console.WriteLine("Correct! Type any key for the next question");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("Incorrect! Type any key for the next question");
                    Console.ReadLine();
                }
            }
            stopwatch.Stop();

            Console.WriteLine($"your score is: {score}. PRess any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Addition, game_difficulty, stopwatch.Elapsed);
        }
    }
}

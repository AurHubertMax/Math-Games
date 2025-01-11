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

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Modulus);
        }

        internal void DivisionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Division selected");
                var division_numbers = Helpers.GetDivisionNumbers();
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

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Multiplication selected");
                first_number = random.Next(1, 9);
                second_number = random.Next(1, 9);
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

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void SubtractionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Subtraction selected");
                first_number = random.Next(1, 9);
                second_number = random.Next(1, 9);
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

            Console.WriteLine($"your score is: {score}");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void AdditionGame()
        {
            var random = new Random();
            int first_number;
            int second_number;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Addition selected");
                first_number = random.Next(1, 9);
                second_number = random.Next(1, 9);
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

            Console.WriteLine($"your score is: {score}. PRess any key to go back to the main menu.");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Addition);
        }
    }
}

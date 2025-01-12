using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Games.Models;
using System.Linq;

namespace Math_Games
{
    internal class Helpers
    {
        internal static List<Game> games = new();
        internal static void PrintGames()
        {
            //var games_to_print = games.Where(x => x.Type == GameType.Division);
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("----------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} - {game.GameDifficulty}: {game.Score} points in {game.ElapsedTime}s");
            }
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("Press any key to go back to the main menu");
            Console.ReadLine();
        }

        internal static void AddToHistory(int score, GameType game, Difficulty GameDiff, TimeSpan elapsed)
        {
            games.Add(new Game
            {
                Score = score,
                Date = DateTime.Now,
                Type = game,
                GameDifficulty = GameDiff,
                ElapsedTime = elapsed
            });
        }

        internal static int[] GetDivisionNumbers(int multiplier)
        {
            var random = new Random();
            var first_number = random.Next(1 * multiplier, 99 * multiplier);
            var second_number = random.Next(1 * multiplier, 99 * multiplier);
            var result = new int[2];

            while (first_number % second_number != 0)
            {
                first_number = random.Next(1 * multiplier, 99 * multiplier);
                second_number = random.Next(1 * multiplier, 99 * multiplier);
            }


            result[0] = first_number;
            result[1] = second_number;

            return result;
        }

        internal static string? ValidateResult(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again:");
                result = Console.ReadLine();
            }

            return result;
        }

        internal static string? GetName()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Your name can't be empty");
                name = Console.ReadLine();
            }
            return name;
        }

        internal static object GetGameDifficulty()
        {
            Console.Clear();
            Console.WriteLine("Select difficulty level");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Medium");
            Console.WriteLine("3 - Hard");
            Console.WriteLine("--------------------------------------");
            var difficulty = Console.ReadLine();
            switch (difficulty)
            {
                case "1":
                    return Difficulty.Easy;
                case "2":
                    return Difficulty.Medium;
                case "3":
                    return Difficulty.Hard;
                default:
                    while (difficulty != "1" && difficulty != "2" && difficulty != "3")
                    {
                        Console.WriteLine("Invalid input. Please Try again:");
                        difficulty = Console.ReadLine();
                    }
                    return difficulty;
            }
        }
    }
}

namespace Math_Games
{
    internal class Menu // internal access modifier = class can be accessed anywhere in the project
    {
        GameEngine engine = new();
        internal void ShowMenu(string? name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");

            Console.WriteLine($"Hello {name}. Today is {date.DayOfWeek}, the {date.Day} of the month {date.Month} in {date.Year}");
            Console.WriteLine("\n");

            bool is_game_on = true;
            do
            {
                
                Console.WriteLine($@"
        Pick one to play: 
        V - View previous games
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Division
        P - Modulus
        Q - Quit the program");
                Console.WriteLine("--------------------------------------");

                var gameSelected = Console.ReadLine();
                switch (gameSelected?.Trim().ToLower())
                {
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "a":
                        engine.AdditionGame();
                        break;
                    case "s":
                        engine.SubtractionGame();
                        break;
                    case "m":
                        engine.MultiplicationGame();
                        break;
                    case "d":
                        engine.DivisionGame();
                        break;
                    case "p":
                        engine.ModulusGame();
                        break;
                    case "q":
                        Console.WriteLine("Exiting...");
                        is_game_on = false;
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("not a valid input");
                        break;

                }
            } while (is_game_on);

        }
            
    }

}

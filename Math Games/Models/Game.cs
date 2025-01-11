namespace Math_Games.Models;

internal class Game
{
    internal int Score { get; set; }

    internal DateTime Date { get; set; }
    
    required internal GameType Type { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Modulus
}
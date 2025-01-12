namespace Math_Games.Models;

internal class Game
{
    public TimeSpan ElapsedTime { get; internal set; }
    internal int Score { get; set; }

    internal DateTime Date { get; set; }
    
    required internal GameType Type { get; set; }

    internal Difficulty GameDifficulty { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Modulus
}

internal enum Difficulty
{
    Easy,
    Medium,
    Hard
}
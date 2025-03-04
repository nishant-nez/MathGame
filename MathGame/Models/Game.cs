﻿namespace MathGame.Models
{
    internal class Game
    {
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public GameType Type { get; set; }
        public GameDifficulty Difficulty { get; set; }
        public string Duration { get; set; } = "0";
    }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
    Random
}

internal enum GameDifficulty
{
    Easy,
    Medium,
    Hard
}
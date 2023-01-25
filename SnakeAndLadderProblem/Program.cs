using System;

namespace SnakeAndLadderProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____Welcome to Snake and Ladder Program_____");
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.CheckOption();
            Console.ReadLine();
        }
    }
}

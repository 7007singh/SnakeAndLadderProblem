using System;
using System.Net.Mime;

namespace SnakeAndLadderProblem
{
    internal class SnakeLadder
    {
        const int LADDER = 1;
        const int SNAKE_BITE = 2;
        const int NO_PLAY = 3;
        public int position, dieNumber, option, player;

        Random random = new Random();
        public void CheckOption()
        {
                option = random.Next(1, 4);
                dieNumber = random.Next(1, 7);
                Console.WriteLine("Dice Number " + dieNumber);
                switch (option)
                {
                    case LADDER:
                        Console.WriteLine("Ladder");
                        position += dieNumber;
                        Console.WriteLine("Player Position: " + position);
                        break;
                    case SNAKE_BITE:
                        Console.WriteLine("Snake Bite");
                        position -= dieNumber;
                        Console.WriteLine("Player Position: " + position);
                        break;
                    case NO_PLAY:
                        Console.WriteLine("No Play");
                        Console.WriteLine("Player Position: " + position);
                        break;
                }
        }
    }
}

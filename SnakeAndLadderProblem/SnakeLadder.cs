using System;

namespace SnakeAndLadderProblem
{
    internal class SnakeLadder
    {
        const int LADDER = 1;
        const int SNAKE_BITE = 2;
        const int NO_PLAY = 3;
        public int position, dieNumber, option, dieCount = 0;

        Random random = new Random();
        public void CheckOption()
        {
            while (position < 100)
            {
                option = random.Next(1, 4);
                dieNumber = random.Next(1, 7);
                Console.WriteLine("\nDice Number " + dieNumber);
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
                if(position < 1)
                {
                    position = 0;
                    Console.WriteLine("\nAfter moving position below 0");
                    Console.WriteLine("Players Position: " + position);
                }
                if(position > 100)
                {
                    position = Convert.ToInt32(position<=100);
                }
                dieCount++;
            }
            Console.WriteLine("{0} Times Die Rolled", dieCount);
        }
    }
}

using System;

namespace SnakeAndLadderProblem
{
    internal class SnakeLadder
    {
        const int LADDER = 1;
        const int SNAKE_BITE = 2;
        const int NO_PLAY = 3;
        public int dieNumber, option, dieCount = 0, player1Position = 0, player2Position = 0;

        Random random = new Random();
        public void CheckOption()
        {
            while (player1Position < 100 || player2Position < 100)
            {
                option = random.Next(1, 4);
                dieNumber = random.Next(1, 7);
                Console.WriteLine("\nDice Number " + dieNumber);

                if (dieNumber % 2 == 0)
                {

                    switch (option)
                    {
                        case LADDER:
                            Console.WriteLine("Ladder");
                            player1Position += dieNumber;
                            Console.WriteLine("Player1 Position: " + player1Position);
                            break;
                        case SNAKE_BITE:
                            Console.WriteLine("Snake Bite");
                            player1Position -= dieNumber;
                            Console.WriteLine("Player1 Position: " + player1Position);
                            break;
                        case NO_PLAY:
                            Console.WriteLine("No Play");
                            Console.WriteLine("Player1 Position: " + player1Position);
                            break;
                    }

                    if (player1Position < 0)
                    {
                        player1Position = 0;
                        Console.WriteLine("\nAfter moving position below 0");
                        Console.WriteLine("Players1 Position: " + player1Position);
                    }

                    if (player1Position > 100)
                    {
                        player1Position = Convert.ToInt32(player1Position < 100);
                    }

                    if (player1Position == 100)
                    {
                        Console.WriteLine("Player1 Won");
                        break;
                    }
                }
                else
                {
                    switch (option)
                    {
                        case LADDER:
                            Console.WriteLine("Ladder");
                            player2Position += dieNumber;
                            Console.WriteLine("Player2 Position: " + player2Position);
                            break;
                        case SNAKE_BITE:
                            Console.WriteLine("Snake Bite");
                            player2Position -= dieNumber;
                            Console.WriteLine("Player2 Position: " + player2Position);
                            break;
                        case NO_PLAY:
                            Console.WriteLine("No Play");
                            Console.WriteLine("Player2 Position: " + player2Position);
                            break;
                    }

                    if (player2Position < 0)
                    {
                        player2Position = 0;
                        Console.WriteLine("\nAfter moving position below 0");
                        Console.WriteLine("Players2 Position: " + player2Position);
                    }

                    if (player2Position > 100)
                    {
                        player2Position = Convert.ToInt32(player2Position < 100);
                    }

                    if (player2Position == 100)
                    {
                        Console.WriteLine("Player2 won");
                        break;
                    }
                }
                dieCount++;
            }
            Console.WriteLine("number of die count: " + dieCount);
        }
    }
}

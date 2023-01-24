using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    internal class SnakeLadder
    {
        public int position = 0;
        public int player;

        Random random = new Random();
        public void Start()
        { 
            int dieNumber = random.Next(1, 7);
            Console.WriteLine("dice Number: " + dieNumber);
            player = position;
            Console.WriteLine("Position of Player: " + position);
        }
    }
}

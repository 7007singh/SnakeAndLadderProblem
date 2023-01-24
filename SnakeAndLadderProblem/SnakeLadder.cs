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
        public void Start()
        { 
            player = position;
            Console.WriteLine("Position of Player: " + position);
        }
    }
}

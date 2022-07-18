using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadder
    {
        private int PlayerPosition;
        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position: {0} ", PlayerPosition);
        }
    }
}
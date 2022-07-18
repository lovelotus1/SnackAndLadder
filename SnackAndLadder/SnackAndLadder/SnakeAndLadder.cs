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
        //public void StartGame()
        public void DiceRolled()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position: {0} ", PlayerPosition);
            Random random = new Random();
            int DiceRolled = random.Next(1, 7);
            Console.WriteLine("Dice Rolled : {0} ", DiceRolled);
            PlayerPosition = PlayerPosition + DiceRolled;
            Console.WriteLine("Player Position: {0}", PlayerPosition);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadder
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int snake = 2;
        private int PlayerPosition;
        public const int Winning = 100;
        int StartPoint = 0;
        int Count = 0;
        public void StartGame()

        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position:", PlayerPosition);
            Random random = new Random();

            while (StartPoint < Winning)//while loop loops through a block of code as long as a specified condition is True
            {
                Count++;
                int DiceRolled = random.Next(1, 7);
                int Option = random.Next(0, 3);
                switch (Option)//switch statement to select one of many code blocks to be executed.
                {
                    case No_Play:
                        Console.WriteLine("No Play");
                        break;
                    case Ladder:
                        StartPoint += DiceRolled;
                        Console.WriteLine("Dice Rolls Value : +{0} ", DiceRolled);
                        Console.WriteLine("Got Ladder : " + StartPoint);
                        if (StartPoint > Winning)
                        {
                            StartPoint -= DiceRolled;
                        }
                        Console.WriteLine("Player Position : " + StartPoint);
                        break;
                    case snake:
                        StartPoint -= DiceRolled;
                        Console.WriteLine("Dice Rolls Value : -{0}", DiceRolled);
                        Console.WriteLine("Snake Attack : " + StartPoint);
                        if (StartPoint < 0)
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("Player Position : " + StartPoint);
                        break;
                }
                //if (StartPoint >= Winning)
                if (StartPoint == Winning)//if to specify a block of code to be executed, if a specified condition is true
                {
                   // Console.WriteLine("Won");
                    Console.WriteLine(" Num of times dice rolled : {0}", +Count);
                    Console.WriteLine("======PLAYER WON======");
                    Console.WriteLine("*****GAME END*****");

                }
            }

            

        }

    }

}



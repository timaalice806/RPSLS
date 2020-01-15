﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciz
{
    class Human : Player
    {
        int count = 1;
        public override void InitGestureList()
        {
            gestureList = new List<string>() { "rock", "Paper", "Scissors", "Lizard", "Spock" };
            foreach (string gesture in gestureList)
            {
                Console.WriteLine(count++ + "." + " " + gesture);
            }
            Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("Choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
            playerChoice = int.Parse(Console.ReadLine());
        }
    }
}

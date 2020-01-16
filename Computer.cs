using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciz
{
    class Computer : Player
    {
        //MEMBER VARIABLES (COMPUTER HAS A)
        

        //CONSTRUCTOR (COMPUTER DEFAULT SETTINGS)
        public Computer()
        {
           
        }

        //MEMBER METHODS (COMPUTER CAN DO)
        int count = 1;
        public override void InitGestureList()
        {
            gestureList = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            foreach (string gesture in gestureList)
            {
                Console.WriteLine(count++ + "." + " " + gesture);
            }
            Console.ReadLine();
        }
        public override void ChooseGesture()
        {
            Random random = new Random();
            playerChoice = random.Next(1,5);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciz
{
    class Game
    {
        //1. Finish getting rid of the errors in the CompareGestures()
        //2. Create a method to determine if a game winner

        Player player1;
        Player player2;
        Random num = new Random();
        
        
        //player1 = new Human()


        public void GameInit()
        {   
            string welcomeMessage = "Welcome to Rock Paper Scissors Lizards and Spock!!!";
            Console.WriteLine(welcomeMessage.PadLeft(welcomeMessage.Length + 33));
            Console.WriteLine("What is your name?");
            String userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hi, {userName}, here are the rules. Scissors cuts paper, paper covers rock, rock crushes lizard,\nlizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper,\npaper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes scissors. \n \n");
            Console.WriteLine("How many players do you have?");


            int userChoice = int.Parse(Console.ReadLine());
            

            if(userChoice == 1)
            {
                Console.WriteLine();
                player1 = new Human();
                player2 = new Computer();
                player1.ChooseGesture();
                player2.ChooseGesture();
            }
            else if(userChoice == 2)
            {
                player1 = new Human();
                player2 = new Human();
                player1.ChooseGesture();
                player2.ChooseGesture();
                //GameInit();
            }
            else
            {
                Console.WriteLine("You didn't read the instructions did you, your options are 1 of 2, that's it 1 or 2.");
                Console.ReadLine();
                GameInit();
            }
        }
        public void CompareGestures()
        {
            while (player1.score < 2 || player2.score < 2)
            {
                Console.WriteLine("Player 1, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                int player1Choice = int.Parse(Console.ReadLine());
                Console.WriteLine(player1Choice);
                Console.Clear();

                Console.WriteLine("Player 2, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                int player2Choice = int.Parse(Console.ReadLine());
                Console.WriteLine(player2Choice);

                Console.WriteLine($"player1: {player1Choice} player2: {player2Choice}");
                Console.ReadLine();

                if (player1Choice == player2Choice)
                {
                    Console.WriteLine("this is a tie please try again");
                    Console.ReadLine();
                }
                else if (player1Choice == 1 && (player2Choice == 3 || player2Choice == 5))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1Choice == 3 && (player2Choice == 2 || player2Choice == 5))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1Choice == 2 && (player2Choice == 1 || player2Choice == 4))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1Choice == 4 && (player2Choice == 3 || player2Choice == 1))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1Choice == 5 && (player2Choice == 4 || player2Choice == 2))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else
                {
                    player2.score++;
                    Console.WriteLine($"Player two {player2.score} score");
                    Console.ReadLine();
                }
            }
        }
        public void DetermineGameWinner ()
        {
            if(player1.score == 2)
            {
                Console.WriteLine("Game winner: Player 1");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Game winner: Player 2");
                Console.ReadLine();
            }
        }
    }
}

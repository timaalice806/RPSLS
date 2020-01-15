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
            
            }
            else if(userChoice == 2)
            {
                player1 = new Human();
                player2 = new Human();
               
                //GameInit();
            }
            else
            {
                Console.WriteLine("You didn't read the instructions did you, your options are 1 of 2, that's it 1 or 2.");
                Console.ReadLine();
                GameInit();
            }
            RunGame();
        }
        public void RunGame()
        {
            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
        }
        public void CompareGestures()
        {
           
                //Console.WriteLine("Player 1, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                //int player1.playerChoice = int.Parse(Console.ReadLine());
                //Console.WriteLine(player1.playerChoice);
                //Console.Clear();

                //Console.WriteLine("Player 2, choose from these following options: \n 1.Rock \n 2.Paper \n 3.Scissors \n 4.Lizard \n 5.Spock");
                //int player2.playerChoice = int.Parse(Console.ReadLine());
                //Console.WriteLine(player2.playerChoice);

                Console.WriteLine($"player1: {player1.playerChoice} player2: {player2.playerChoice}");
                Console.ReadLine();

                if (player1.playerChoice == player2.playerChoice)
                {
                    Console.WriteLine("This is a tie please try again, Press ENTER to continue. ");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 1 && (player2.playerChoice == 3 || player2.playerChoice == 5))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 3 && (player2.playerChoice == 2 || player2.playerChoice == 5))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 2 && (player2.playerChoice == 1 || player2.playerChoice == 4))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 4 && (player2.playerChoice == 3 || player2.playerChoice == 1))
                {
                    player1.score++;
                    Console.WriteLine($"Player one {player1.score} score");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 5 && (player2.playerChoice == 4 || player2.playerChoice == 2))
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

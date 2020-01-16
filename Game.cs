using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSciz
{
    class Game
    {
        Player player1;
        Player player2;
        Random num = new Random();

        public void GameInit()
        {   
            string welcomeMessage = "Welcome to Rock Paper Scissors Lizard Spock";
            Console.WriteLine(welcomeMessage.PadLeft(welcomeMessage.Length + 33));
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hi, {userName}, here are the rules. \n Scissors cuts paper, paper covers rock, rock crushes lizard,\nlizard poisons Spock, Spock smashes scissors, scissors decapitates lizard, lizard eats paper,\npaper disproves Spock, Spock vaporizes rock, and as it always has, rock crushes scissors. \n \n");
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
            }
            else
            {
                Console.WriteLine("Invalid input, your options are 1 or 2.");
                Console.ReadLine();
                GameInit();
            }
        }
        public void RunGame()
        {
            GameInit();
            while (player1.score < 2 && player2.score < 2)
            {
                player1.ChooseGesture();
                player2.ChooseGesture();
                CompareGestures();
            }
            DetermineGameWinner();
        }
        public void CompareGestures()
        {
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
                    Console.WriteLine($"Player one has scored {player1.score} point(s)");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 3 && (player2.playerChoice == 2 || player2.playerChoice == 5))
                {
                    player1.score++;
                    Console.WriteLine($"Player one has scored {player1.score} point(s)");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 2 && (player2.playerChoice == 1 || player2.playerChoice == 4))
                {
                    player1.score++;
                    Console.WriteLine($"Player one has scored {player1.score} point(s)");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 4 && (player2.playerChoice == 3 || player2.playerChoice == 1))
                {
                    player1.score++;
                    Console.WriteLine($"Player one has scored {player1.score} point(s)");
                    Console.ReadLine();
                }
                else if (player1.playerChoice == 5 && (player2.playerChoice == 4 || player2.playerChoice == 2))
                {
                    player1.score++;
                    Console.WriteLine($"Player one has scored {player1.score} point(s)");
                    Console.ReadLine();
                }
                else
                {
                    player2.score++;
                    Console.WriteLine($"Player two has scored {player2.score} point(s)");
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

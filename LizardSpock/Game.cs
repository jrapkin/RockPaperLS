using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Game
	{


        Player playerOne;
        Player playerTwo;
        int playerOneScore;
        int playerTwoScore;
        public Game()
        {
            playerOneScore = 0;
            playerTwoScore = 0;
            
        }

        public void RunGame()
        {
            WelcomeMessage();
            SetPlayers();
            do
            {
               
                playerOne.PickGesture();
                playerTwo.PickGesture();
                DisplayPlayerChoice();
                CompareMoves();
                Console.WriteLine($"Player one has {playerOneScore} points. \nPlayer two has {playerTwoScore} points.\n\n");

            }
            while (playerOneScore <3 && playerTwoScore <3);
            DisplayGameWinner();
            NewGameCheck();
            QuitGame();
        }


        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. \n \n");
            Console.WriteLine("The rules of the game are simple! \nRock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock \n" );
        }

        public string DetermineNumberOfPlayers()
        {
            Console.WriteLine("Would you like to play single player or two player?");
            string numberOfPlayers = TakePlayerInput();
            return numberOfPlayers;
        }

        public void SetPlayers()
        {
            bool validSelectionCheck = false;
            do
            {
                string numberOfPlayers = DetermineNumberOfPlayers();
                if (numberOfPlayers == "single player")
                {
                    playerOne = new Human();
                    playerTwo = new AI();
                    validSelectionCheck = true;
                }
                else if (numberOfPlayers == "two player")
                {
                    playerOne = new Human();
                    playerTwo = new Human();
                    validSelectionCheck = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid selection. \n Enter single player if you want to test your might against the computer. \n Enter two player if you want to test your might against another human!");
                    
                }
            }
            while (validSelectionCheck == false);
        }

        public string TakePlayerInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }

        public void DisplayPlayerChoice()
        {
            Console.WriteLine($" {playerOne.name} has chosen {playerOne.chosenGesture.name}!");
            Console.WriteLine($" {playerTwo.name} has chosen {playerTwo.chosenGesture.name}!");
        }
        private void CompareMoves()
        {


            if (playerTwo.chosenGesture.lossConditions.Contains(playerOne.chosenGesture.name))
            {
                Console.WriteLine("Player one wins this round!");
                playerOneScore++;
            }
            else if (playerOne.chosenGesture.lossConditions.Contains(playerTwo.chosenGesture.name))
            {
                Console.WriteLine("Player two Wins this round!");
                playerTwoScore++;
            }

            else
            { Console.WriteLine("It's a tie!"); }
        }

        public void DisplayGameWinner()
        {

            if (playerOneScore >= 3)
            {
                Console.WriteLine($"{playerOne.name} has won the game.");
            }
            else if (playerTwoScore >= 3)
            {
                Console.WriteLine($"{playerTwo.name} has won the game.");
            }

        }

        private void NewGameCheck()
        {
            Console.WriteLine("Do you want to play again?");
            bool newGameCheck = false;
            do
            {
                string userInput = TakePlayerInput();
                switch (userInput)
                {
                    case "yes":
                    case "Yes":
                    case "new game":
                    case "New Game":
                    case "1":
                        newGameCheck = true;
                        RunGame();
                        break;

                    case "no":
                    case "No":
                    case "2":
                        QuitGame();
                        newGameCheck = true;
                        break;

                    default:
                        Console.WriteLine("Please make a valid selection. Press 1 to start a new game. Press 2 to exit the game.");
                        break;
                }

                
            }
            while (newGameCheck == false) ;

        }
            
        private void QuitGame()
        {
            Console.WriteLine("Thank you for playing Rock, Paper, Scissors, Lizard, Spock. \n Play again soon, and check out Season 2 Episode 8 for more Lizard, Spock Fun!");
        }


    }
}

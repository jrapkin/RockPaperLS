using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Game
	{


        Player PlayerOne;
        Player PlayerTwo;
        int PlayerOneScore;
        int PlayerTwoScore;
        public Game()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
            
        }

        public void RunGame()
        {
            WelcomeMessage();
            SetPlayers();
            do
            {
               
                PlayerOne.PickGesture();
                PlayerTwo.PickGesture();
                DisplayPlayerChoice();
                CompareMoves();
                Console.WriteLine($"Player one has {PlayerOneScore} points. \nPlayer two has {PlayerTwoScore} points.\n\n");

            }
            while (PlayerOneScore <3 && PlayerTwoScore <3);
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
                    PlayerOne = new Human();
                    PlayerTwo = new AI();
                    validSelectionCheck = !validSelectionCheck;
                }
                else if (numberOfPlayers == "two player")
                {
                    PlayerOne = new Human();
                    PlayerTwo = new Human();
                    validSelectionCheck = !validSelectionCheck;
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
            Console.WriteLine($" {PlayerOne.Name} has chosen {PlayerOne.ChosenGesture.Name}!");
            Console.WriteLine($" {PlayerTwo.Name} has chosen {PlayerTwo.ChosenGesture.Name}!");
        }
        private void CompareMoves()
        {


            if (PlayerTwo.ChosenGesture.lossConditions.Contains(PlayerOne.ChosenGesture.Name))
            {
                Console.WriteLine("Player one wins this round!");
                PlayerOneScore++;
            }
            else if (PlayerOne.ChosenGesture.lossConditions.Contains(PlayerTwo.ChosenGesture.Name))
            {
                Console.WriteLine("Player two Wins this round!");
                PlayerTwoScore++;
            }

            else
            { Console.WriteLine("It's a tie!"); }
        }
        public void DisplayGameWinner()
        {

            if (PlayerOneScore >= 3)
            {
                Console.WriteLine($"{PlayerOne.Name} has won the game.");
            }
            else if (PlayerTwoScore >= 3)
            {
                Console.WriteLine($"{PlayerTwo.Name} has won the game.");
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
                        newGameCheck = !newGameCheck;
                        RunGame();
                        break;

                    case "no":
                    case "No":
                    case "2":
                        QuitGame();
                        newGameCheck = !newGameCheck;
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

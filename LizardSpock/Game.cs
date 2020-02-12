﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Game
	{


        ///<summary>
        ///This is going to be top level logic for the game, where rounds will be handeled, and where I plan to have classes called to. 
        ///I may sort validation into its own class depending on how issues present themselves.
        ///</summary>


        //Member Variables/ Properties
        Player PlayerOne;
        Player PlayerTwo;
        int PlayerOneScore;
        int PlayerTwoScore;
        Random random;

        //list of gestures vs gesture class>>>>>>>>>>>>>>>>>??????????????????
        public Game()
        {
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
            random = new Random();
        }

        //MAIN METHOD
        public void RunGame()
        {
            //WelcomeMessage();
                //Display Rules of the game
            WelcomeMessage();
            //single player or two player?
            //validate user input
            DetermineNumberOfPlayers();
            SetPlayers();

            //if single player selected, (choose name??)
            //set up New single player Game in valid state
            //else if second plyer selected
            //set up new two player game in valid state
            //else if quit selected
            //quit
            // else
            //prompt user for valid input
            PlayerOne.PickGesture();
            PlayerTwo.PickGesture();


            //New Single Player Game
            //Loop / Itteration begin?
            //Determine who goes first
            //Present Player 1 with options (Pick move method)
            //validate user input
            //if Valid user input results in 
            //Move to AI's OR Player 2's turn 
            //if invalid user input, prompt for a valid selection
            //AI's turn
            //select "pick move method" (if AI then random generate pick)  of gesture/move
            //determine round winner
            //compare gestures
            //decide which gesture is the winner


            //continue loop until best of 3 is reached
        }


        //Member Methods
        private void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock. \n \n");
            Console.WriteLine("The rules of the game are simple! \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n" );
        }

        //Welcome message --presents start (single player or 2 player?) / quit

        public string DetermineNumberOfPlayers()
        {
            Console.WriteLine("Would you like to play single player or two player?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }

        public void SetPlayers()
        {
            string numberOfPlayers = DetermineNumberOfPlayers();
            if (numberOfPlayers == "single player")
            {
                PlayerOne = new Human();
                PlayerTwo = new AI();
            }
            else if (numberOfPlayers == "two player") 
            { 
            PlayerOne = new Human();
            PlayerTwo = new Human();
            }
            else
            { 
                Console.WriteLine("Please enter a valid selection. \n Enter single player if you want to test your might against the computer. \n Enter two player if you want to test your might against another human!"); 
            }
        }

        
        public string TakePlayerInput()
        {
            string userInput = Console.ReadLine();

            return userInput;
        }

        private void NewGame()
        {
            bool newGameCheck = false;

            do
            {
                string userInput = TakePlayerInput();

                switch (userInput)
                {
                    case "yes":
                        GameLogic();
                        newGameCheck = !newGameCheck;
                        break;

                    case "Yes":
                        GameLogic();
                        newGameCheck = !newGameCheck;
                        break;
                    case "new game":
                        GameLogic();
                        newGameCheck = !newGameCheck;
                        break;
                    case "New Game":
                        GameLogic();
                        newGameCheck = !newGameCheck;
                        break;

                    case "1":
                        GameLogic();
                        newGameCheck = !newGameCheck;
                        break;

                    case "no":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;

                    case "No":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;

                    case "2":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;
                    case "quit game":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;
                    case "Quit Game":
                        QuitGame();
                        newGameCheck = !newGameCheck;
                        break;
                    default:
                        Console.WriteLine("Please make a valid selection.");
                        Console.WriteLine("Press 1, or type 'new game' to start a new game. Press 2 or type 'quit game' to exit the game. \n \n");
                        break;
                }

            }
            while (newGameCheck == false);

        }

        private void QuitGame()
            {
                Console.WriteLine("Thank you for playing Rock, Paper, Scissors, Lizard, Spock. \n Play again soon, and check out Season 2 Episode 8 for more Lizard, Spock Fun!");
            }


    }
}
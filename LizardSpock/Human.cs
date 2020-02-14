using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Human : Player
	{

		public Human()
		{
			SetName();
			
		}
		public override void SetName()
		{
			Console.WriteLine("What is your name?");
			name = Console.ReadLine();
			Console.WriteLine($"{name} has joined the game!");
		}

		public override void PickGesture()
		{
			chosenGesture = ValidateUserInput();
			 		   
		}
		public Gesture ValidateUserInput()
		{
			bool validationCheck = false;
	
			do
			{
				Console.WriteLine("Please Choose a move!");
				string playerInput = Console.ReadLine();

				switch (playerInput)
				{
					case "Rock":
					case "rock":
						validationCheck = true;
						return gestureOptions[0];
						
					case "Paper":
					case "paper":
						validationCheck = true;
						return gestureOptions[1];
					case "Scissors":
					case "scissors":
						validationCheck = true;
						return gestureOptions[2];
					case "Lizard":
					case "lizard":
						validationCheck = true;
						return gestureOptions[3];

					case "Spock":
					case "spock":
						validationCheck = true;
						return gestureOptions[4];
					default:
						Console.WriteLine("Not a valid choice, please choose Rock, Paper, Scissors, Lizard, or Spock");
						break;
				}
			}
			while (validationCheck == false);

			return ValidateUserInput();
			
			
		}

		



	}
}

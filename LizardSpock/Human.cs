using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Human : Player
	{
		//Member Variables/ Properties


		//Constructor
		public Human()
		{
			SetName();
			
		}

		//Member Methods
		public override void SetName()
		{
			Console.WriteLine("What is your name?");
			Name = Console.ReadLine();
			Console.WriteLine($"{Name} has joined the game!");
		}
		//picks a move
		public override void PickGesture()
		{
			/*			int i = ValidateUserInput();
						string test = ValidateUserInput();*/
			ChosenGesture = ValidateUserInput();
			 		   
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
						validationCheck = !validationCheck;
						return GestureOptions[0];
						
					case "Paper":
					case "paper":
						validationCheck = !validationCheck;
						return GestureOptions[1];
					case "Scissors":
					case "scissors":
						validationCheck = !validationCheck;
						return GestureOptions[2];
					case "Lizard":
					case "lizard":
						validationCheck = !validationCheck;
						return GestureOptions[3];

					case "Spock":
					case "spock":
						validationCheck = !validationCheck;
						return GestureOptions[4];
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

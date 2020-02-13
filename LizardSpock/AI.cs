using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class AI : Player
	{
		//Member Variables/ Properties
		Random GetRandom;

		//Constructor
		public AI()
		{
			SetName();
			GetRandom = new Random();
		}

		//Member Methods
		public override void PickGesture()
		{
			//ChosenGesture = GestureOptions[1];
			int aiRoll = GetRandom.Next(0, 5);
			if (aiRoll == 0)
			{
				ChosenGesture = GestureOptions[0];

			}
			if (aiRoll == 1)
			{
				ChosenGesture = GestureOptions[1];
			}
			if (aiRoll == 2)
			{
				ChosenGesture = GestureOptions[2];
			}
			if (aiRoll == 3)
			{
				ChosenGesture = GestureOptions[3];
			}
			if (aiRoll == 4)
			{
				ChosenGesture = GestureOptions[4];
			}



		}
		public override void SetName()
		{
			Name = "Skynet";
			Console.WriteLine($"{Name} has joined the game!");
		}


	}
}

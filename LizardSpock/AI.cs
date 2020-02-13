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
/*			test value ChosenGesture = GestureOptions[1].Name;
*/			int aiRoll = GetRandom.Next(0, 6);
			if (aiRoll == 0)
			{
				ChosenGesture = GestureOptions[0].Name;
				
			}
			if (aiRoll == 1)
			{
				ChosenGesture = GestureOptions[1].Name;
			}
			if (aiRoll == 2)
			{
				ChosenGesture = GestureOptions[2].Name;
			}
			if (aiRoll == 3)
			{
				ChosenGesture = GestureOptions[3].Name;
			}
			if (aiRoll == 4)
			{
				ChosenGesture = GestureOptions[4].Name;
			}
			if (aiRoll == 5)
			{
				ChosenGesture = GestureOptions[5].Name;
			}


		}
		public override void SetName()
		{
			Name = "Skynet";
			Console.WriteLine($"{Name} has joined the game!");
		}


	}
}

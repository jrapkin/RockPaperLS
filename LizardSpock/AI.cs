using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class AI : Player
	{
		Random getRandom;

		//Constructor
		public AI()
		{
			SetName();
			getRandom = new Random();
		}

		public override void PickGesture()
		{
			int aiRoll = getRandom.Next(0, 5);
			if (aiRoll == 0)
			{
				chosenGesture = gestureOptions[0];

			}
			if (aiRoll == 1)
			{
				chosenGesture = gestureOptions[1];
			}
			if (aiRoll == 2)
			{
				chosenGesture = gestureOptions[2];
			}
			if (aiRoll == 3)
			{
				chosenGesture = gestureOptions[3];
			}
			if (aiRoll == 4)
			{
				chosenGesture = gestureOptions[4];
			}



		}
		public override void SetName()
		{
			name = "Skynet";
			Console.WriteLine($"{name} has joined the game!");
		}


	}
}

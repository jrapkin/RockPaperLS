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


		//Constructor
		public AI()
		{
			SetName();
		}

		//Member Methods
		public override void SetName()
		{
			Name = "Skynet";
			Console.WriteLine($"{Name} has joined the game!");
		}


	}
}

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
			Name = Console.ReadLine();
			Console.WriteLine($"{Name} has joined the game!");
		}
		//picks a move
		public override void PickGesture()
		{
			Console.WriteLine("Please Choose a move!");
			gesture = Console.ReadLine();
		}

		



	}
}

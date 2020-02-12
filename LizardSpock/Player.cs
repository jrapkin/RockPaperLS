using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	public abstract class Player
	{
		//Member Variables/ Properties
		public string Name;
		public int Score;
		public string gesture;
		//Gesture gesture

		//Constructor
		public Player()
		{

		}

		//Member Methods


		public abstract void SetName();
		public abstract void PickGesture();

		//makes/picks a move (gesture)


	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Gestures

	{
		//member variables
		int Rock = 1;
		int Paper = 2;
		int Scissors = 3;
		int Lizard = 4;
		int Spock = 5;

		// constructor
		public Gestures()
		{

		}
		List<string> gestures = new List<string>();
		public void AddToListOfGestures()
		{
			gestures.Add("Rock");
			gestures.Add("Paper");
			gestures.Add("Scissors");
			gestures.Add("Lizard");
			gestures.Add("Spock");
		}

		//methods

		
	}
}

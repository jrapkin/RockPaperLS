using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Scissors : Gesture
	{
		public Scissors()
		{
			name = "Scissors";
			lossConditions = new List<string>() { "Rock", "Spock" };


		}
	}
}

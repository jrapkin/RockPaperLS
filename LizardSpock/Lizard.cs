using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Lizard : Gesture
	{
		public Lizard()
		{
			name = "Lizard";
			lossConditions = new List<string>() { "Scissors", "Rock" };

		}

	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Spock : Gesture
	{
		public Spock()
		{
			name = "Spock";
			lossConditions = new List<string>() { "Lizard", "Paper" };
		}

	}
}

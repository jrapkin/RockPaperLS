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
			Name = "Spock";
			lossConditions = new List<string>();
			AddToListOfLossConditions();
		}

		public override void AddToListOfLossConditions()
		{

			lossConditions.Add("Lizard");
			lossConditions.Add("Paper");
		}
	}
}

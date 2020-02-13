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
			Name = "Scissors";
			lossConditions = new List<string>();
			AddToListOfLossConditions();
		}

		public override void AddToListOfLossConditions()
		{

			lossConditions.Add("Rock");
			lossConditions.Add("Spock");
		}
	}
}

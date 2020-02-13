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
			Name = "Lizard";
			lossConditions = new List<string>();
			attack = new List<string>();
			AddToListOfLossConditions();
		}

		public override void AddToListOfLossConditions()
		{

			lossConditions.Add("Scissors");
			lossConditions.Add("Rock");
		}


	}
}

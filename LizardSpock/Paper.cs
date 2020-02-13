using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	class Paper : Gesture
	{
		public Paper()
		{
			Name = "Paper";
			lossConditions = new List<string>();
			AddToListOfLossConditions();
		}

		public override void AddToListOfLossConditions()
		{

			lossConditions.Add("Scissors");
			lossConditions.Add("Lizard");
		}
	}
}

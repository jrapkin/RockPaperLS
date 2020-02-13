using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	public class Rock : Gesture
	{
/*		public List<string> LoseConditions;
*/		
		public Rock()
		{
			Name = "Rock";

			lossConditions = new List<string>();
			AddToListOfLossConditions();
		}


		public override void AddToListOfLossConditions()
		{

			lossConditions.Add("Paper");
			lossConditions.Add("Spock");
		}

		//member method

		


	}
}

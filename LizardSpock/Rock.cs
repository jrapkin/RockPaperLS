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


		public void AddToListOfLossConditions()
		{

			lossConditions.Add("Paper");
			lossConditions.Add("Spock");
		}

		//member method
		public override void CompareGestures()
		{
			if (lossConditions.Contains(lossConditions[0]))
			{
				Console.WriteLine($"{lossConditions[0]} covers {Name}!");
			}
			else if (lossConditions.Contains(lossConditions[1]))
			{
				Console.WriteLine($"{lossConditions[1]} vaporizes {Name}!");
			}
			else
			{ Console.WriteLine("It's a tie!"); }
		}


	}
}

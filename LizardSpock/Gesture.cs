using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	public abstract class Gesture 

	{
		//member variables
		public string Name;
		public List<string> lossConditions;
		// constructor
		public Gesture()
		{

		}
		//methods

		public abstract void CompareGestures();

/*		Can I actually put a full list of loss conditions here so the child classes inherit the list to check against?
 *		Virtual method to change the list positions based on which loss conditions need to be met?
 *
 *		public void AddToListOfLossConditions()
		{

			lossConditions.Add("Paper");
			lossConditions.Add("Spock");
		}*/





	}
}

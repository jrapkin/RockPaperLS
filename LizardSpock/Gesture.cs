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
		public List<string> attack;
		// constructor
		public Gesture()
		{

		}
		//methods
		public abstract void AddToListOfLossConditions();









	}
}

﻿using System;
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
		}
		//public override void CompareGestures()
		

		
		public void AddToListOfLossConditions()
		{

			lossConditions.Add("Paper");
			lossConditions.Add("Spock");
		}
	}
}

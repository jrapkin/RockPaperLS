﻿using System;
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
			name = "Rock";

			lossConditions = new List<string>() { "Paper", "spock" };

		}

		


	}
}

﻿using System;
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
			name = "Paper";
			lossConditions = new List<string>() { "Scissors", "Lizard" };

		}
	}
}

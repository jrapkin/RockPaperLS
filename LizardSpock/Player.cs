using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizardSpock
{
	public abstract class Player
	{
		//Member Variables/ Properties
		public string Name;
		public int Score;
		public List<Gesture> GestureOptions;
		public Gesture ChosenGesture;

		public Player()
		{
			GestureOptions = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
		}

		public abstract void SetName();
		public abstract void PickGesture();

	}
}

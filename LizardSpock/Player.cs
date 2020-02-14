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
		public string name;
		public int score;
		public List<Gesture> gestureOptions;
		public Gesture chosenGesture;

		public Player()
		{
			gestureOptions = new List<Gesture>() { new Rock(), new Paper(), new Scissors(), new Lizard(), new Spock() };
		}

		public abstract void SetName();
		public abstract void PickGesture();

	}
}

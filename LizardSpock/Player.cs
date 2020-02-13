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
		public string ChosenGesture;

		//Constructor
		public Player()
		{
			GestureOptions = new List<Gesture>();
			AddToListOfGestures();
		}

		//Member Methods
		public void AddToListOfGestures()
		{
			GestureOptions.Add(new Rock());
			GestureOptions.Add(new Paper());
			GestureOptions.Add(new Scissors());
			GestureOptions.Add(new Lizard());
			GestureOptions.Add(new Spock());
		}

		public abstract void SetName();
		public abstract void PickGesture();


		//makes/picks a move (gesture)


	}
}

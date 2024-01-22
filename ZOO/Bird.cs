using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace ZOO
{
	internal class Bird:Animal
	{

		protected int flightAltitude;//גובה התעופה
		protected int wingspanLength;//אורך מוטת כנפיים




		public Bird(string name, int age, bool isSuperPredator, int caloriesPerMeal, int flightAltitude, int wingspanLength)
			: base(name, age, isSuperPredator, caloriesPerMeal)
		{
			this.flightAltitude = flightAltitude;
			this.wingspanLength = wingspanLength;

		}



		//פעולות GET
		public int GetFlightAltitude()
		{
			return this.flightAltitude;
		}

		public int GetWingsPanLength()
		{
			return this.wingspanLength;
		}


		//פעולות SET
		public void SetFlightAltitude( int FlightAltitude)
		{
			this.flightAltitude = FlightAltitude;
		}

		public void SetWingsPanLength( int WingspanLength)
		{
			this.wingspanLength = WingspanLength;
		}



		public override int Eat()
		{
			return this.caloriesPerMeal * 2;
		}



		public void Sing()
		{
			Console.Beep();
			Thread.Sleep(5);
			Console.Beep();
			Thread.Sleep(5);
			Console.Beep();
			Thread.Sleep(100);
			Console.Beep();
			Thread.Sleep(5);
			Console.Beep();
			Thread.Sleep(5);
		}



		public void Dance()
		{
			Console.WriteLine("Dancingg !!");
		}

	

	}
}

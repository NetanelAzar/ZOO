using System;

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



		public override string ToSrtring()
		{
			return base.ToSrtring() + "Aviation altitude:" + this.flightAltitude + " Wingspan length:" + this.wingspanLength;
		}


	}
}

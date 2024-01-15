using System;

namespace ZOO
{
	internal class Crocodile : Reptile
	{


		protected bool DentalCare;



		public Crocodile(string name, int age, bool isSuperPredator, int caloriesPerMeal, int taillength, bool DentalCare)
			: base(name, age, isSuperPredator, caloriesPerMeal, taillength)
		{
			this.DentalCare = DentalCare;
		}



		public bool GetDentalCare()
		{
			return this.DentalCare;
		}


		public void SetDentalCare(bool Dental)
		{
			this.DentalCare = Dental;
		}





		public override string ToString()
		{
			return base.ToString() + " Dental care:" + this.DentalCare;
		}





	}
}

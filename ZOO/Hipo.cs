using System;

namespace ZOO
{
	internal class Hipo : Mammal
	{


		protected int fatPercentage;




		public Hipo(string name, int age, bool isSuperPredator, int caloriesPerMeal, int caloriesInMilk, int pregnancyMonths, int fatPercentage)
			: base(name, age, isSuperPredator, caloriesPerMeal, caloriesInMilk, pregnancyMonths)
		{
			this.fatPercentage = fatPercentage;
		
		}



		///פעולות GET
		public int GetfatPercentage()
		{
			return this.fatPercentage;
		}

		//פעולות SET
		public void SetfatPercentage(int fat)
		{
			this.fatPercentage = fat;
		}



		public override string ToSrtring()
		{
			return base.ToSrtring() + "The number of fat percentages:" + this.fatPercentage;
		}





	}
}

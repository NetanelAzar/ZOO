using System;

namespace ZOO
{
	internal class Cow:Mammal
	{

		protected int NumberOfLitters;





		         ///constructor
		public Cow(string name, int age, bool isSuperPredator, int caloriesPerMeal, int caloriesInMilk, int pregnancyMonths, int NumberOfLitters)
			: base(name, age, isSuperPredator, caloriesPerMeal, caloriesInMilk, pregnancyMonths)
		{
			this.NumberOfLitters = NumberOfLitters;
		}



		         ///פקודות GET
		public int GetNumberOfLitters()
		{
			return this.NumberOfLitters;
		}

		        ///פקודות SET
		public int SetNumberOfLitters(int num)
		{
			this.NumberOfLitters = num;
		}




		public override int Eat()
		{
			return (int)(Math.Round(base.Eat() * 0.25));
		}


		public override string ToSrtring()
		{
			return base.ToSrtring() + "Number of litters:" + this.NumberOfLitters ;
		}






	}
}

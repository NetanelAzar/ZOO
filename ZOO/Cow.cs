using System;

namespace ZOO
{
	internal class Cow:Mammal
	{

		protected int NumberOfLitters;





		         ///constructor
		public Cow(int caloriesInMilk, int pregnancyMonths, int NumberOfLitters)
			: base(caloriesInMilk, pregnancyMonths)
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



		public override string ToSrtring()
		{
			return base.ToSrtring() + "Number of litters:" + this.NumberOfLitters ;
		}






	}
}

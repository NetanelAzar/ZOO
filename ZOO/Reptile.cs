using System;

namespace ZOO
{
	internal class Reptile:Animal
	{

		protected int taillength;


		public Reptilel(string name, int age, bool isSuperPredator, int caloriesPerMeal, int taillength)
			: base(name,age,isSuperPredator,caloriesPerMeal)
		{
			this.taillength = taillength;
		}


		//פעולות GET
		public int GetTailLength()
		{
			return this.taillength;
		}

		//פעולות SET
		public void SetTailLength(int tail)
		{
			this.taillength = tail;
		}





		public override string ToString()
		{
			return base.ToString() + " the length of the tail:" + this.taillength;
		}



	}
}

using System;

namespace ZOO
{
	internal class Reptile:Animal
	{

		protected int taillength;


		public Reptile(string name, int age, bool isSuperPredator, int caloriesPerMeal, int Taillength)
			: base(name,age,isSuperPredator,caloriesPerMeal)
		{
			this.taillength = Taillength;
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


		public override int Eat()
		{
			return base.Eat() * 4;
		}



		public override string ToString()
		{
			return  " the length of the tail:" + this.taillength;
		}



	}
}

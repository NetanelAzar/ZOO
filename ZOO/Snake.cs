using System;

namespace ZOO
{
	internal class Snake : Reptile
	{


		protected bool poisonous;



		public Snake(string name, int age, bool isSuperPredator, int caloriesPerMeal, int taillength, bool poisonous)
			: base(name, age, isSuperPredator, caloriesPerMeal, taillength)
		{
			this.poisonous = poisonous;
		}



		public bool GetPoisonous()
		{
			return this.poisonous;
		}


		public void SetPoisonous(bool poisonous)
		{
			this.poisonous = poisonous;
		}




		public override string ToString()
		{
			return base.ToString() + " poisonous:" + this.poisonous;
		}
	}
}

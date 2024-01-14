using System;

namespace ZOO
{
	internal class Snake : Reptile
	{


		protected bool poisonous;



		public Snake(int taillength, bool poisonous)
			: base(taillength)
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

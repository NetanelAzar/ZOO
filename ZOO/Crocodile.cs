using System;

namespace ZOO
{
	internal class Crocodile : Reptile
	{


		protected bool DentalCare;



		public Crocodile(int taillength, bool DentalCare)
			: base(taillength)
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

using System;


namespace ZOO
{
    internal class Mammal:Animal
	{


     	protected int caloriesInMilk;
	    protected int pregnancyMonths;



        public Mammal(string name, int age, bool isSuperPredator, int caloriesPerMeal, int caloriesInMilk, int pregnancyMonths)
            : base(name,age,isSuperPredator,caloriesPerMeal)///מתוך Animal
        {
            this.caloriesInMilk = caloriesInMilk;
            this.pregnancyMonths = pregnancyMonths;
        }



               //פעולות GET
        public int GetcaloriesInMilk()
        {
            return this.caloriesInMilk;
        }


        public int GetpregnancyMonths()
        {
            return this.pregnancyMonths;

		}



        ///test


                ///פעולות SET
        public void SetcaloriesInMilk(int calories)
        {
            this.caloriesInMilk = calories;

		}


        public void SetpregnancyMonths(int pregnancy)
        {
            this.pregnancyMonths = pregnancy;

		}





        public override string ToString()
        {
            return base.ToString() + " calories in milk:" + this.caloriesInMilk + " Pregnacy period:" + this.pregnancyMonths + " months";
        }


	}
}

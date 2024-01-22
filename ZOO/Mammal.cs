using System;


namespace ZOO
{
    internal class Mammal:Animal
	{


     	protected int caloriesInMilk;
	    protected int pregnancyMonths;



        public Mammal(string name, int age, bool isSuperPredator, int caloriesPerMeal, int caloriesInMilk, int pregnancyMonths)
            : base(name,age,isSuperPredator,caloriesPerMeal)///שולחים לבנאי של האבא
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





                ///פעולות SET
        public void SetcaloriesInMilk(int calories)
        {
            this.caloriesInMilk = calories;

		}


        public void SetpregnancyMonths(int pregnancy)
        {
            this.pregnancyMonths = pregnancy;

		}

        public override int Eat()
        {
            return base.Eat() + this.caloriesInMilk;
        }



        public override string ToString()
        {
            return " calories in milk:" + this.caloriesInMilk + " Pregnacy period:" + this.pregnancyMonths + " months";
        }


	}
}

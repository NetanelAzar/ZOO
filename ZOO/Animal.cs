using System;


namespace ZOO
{


	internal class Animal
	{
		///protected אפשר לגשת מתוך המחקלה וגם מתוך  היורשים 
		protected string name;
		protected int age;
		protected bool isSuperPredator;///האם טורף על
		protected int caloriesPerMeal;///כמה קלוריות בארוחה




		public Animal(string name, int age, bool isSuperPredator, int caloriesPerMeal)
		{
			this.name = name;
			this.age = age;
			this.isSuperPredator = isSuperPredator;
			this.caloriesPerMeal = caloriesPerMeal;
		}


	

		//פעולות GET
	 public string GetName()
	 {
		return this.name;
	 }

 	 public int GetAge()
	 {
		return this.age;
	 }

	 public bool GetIsSuperPredator()
	 {
		return this.isSuperPredator;
	 }

	 public int GetcaloriesPerMeal()
	 {
			return this.caloriesPerMeal;
	 }


        //פעולות SET
	 public void SetName(string name)
	 {
			this.name = name;
	 }


	 public void SetAge(int age)
	 {
			this.age = age;
	 }



	 public void SetIsSuperPredator(bool IsSuperPredator)
	 {
			this.isSuperPredator = IsSuperPredator;
	 }



	 public void SetcaloriesPerMeael(int caloriesl)
	 {
			this.caloriesPerMeal = caloriesl;
	 }




		public virtual int Eat()///כדי שהיורשים יוכלו לבצע OVERRIDE ולדרוס אותה
		{
			return this.caloriesPerMeal * 3;
		}


	 public override string ToString()
	 {
			return "name=" + this.name + " age=" + this.age + " is super predator:" + this.isSuperPredator + " calories per meal:" + this.caloriesPerMeal;
	 }




	}
}
using System;

namespace ZOO
{
	internal class Animal
	{
		protected string name;
		protected int age;
		protected bool isSuperPredator;
		protected int caloriesPerMeal;

		public Animal(string name, int age, bool isSuperPredator, int caloriesPerMeal)
		{
			this.name = name;
			this.age = age;
			this.isSuperPredator = isSuperPredator;
			this.caloriesPerMeal = caloriesPerMeal;
		}

		// פעולות GET
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

		public int GetCaloriesPerMeal()
		{
			return this.caloriesPerMeal;
		}

		// פעולות SET
		public void SetName(string name)
		{
			this.name = name;
		}

		public void SetAge(int age)
		{
			this.age = age;
		}

		public void SetIsSuperPredator(bool isSuperPredator)
		{
			this.isSuperPredator = isSuperPredator;
		}

		public void SetCaloriesPerMeal(int calories)
		{
			this.caloriesPerMeal = calories;
		}

		public virtual int Eat()
		{
			return this.caloriesPerMeal * 3;
		}

		public override string ToString()
		{
			return "name=" + this.name + " age=" + this.age + " is super predator:" + this.isSuperPredator + " calories per meal:" + this.caloriesPerMeal;
		}
	}
}


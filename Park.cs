using System;

namespace ZOO
{
	internal class Park
	{

		public const int MAX_ANIMAL = 1000;
		private Animal[] animals;
		private int counter;

		public Park()
		{
			this.animals = new Animal[MAX_ANIMAL];
			this.counter = 0;
		}

		public void AddAnimal(Animal animal)
		{
			if (counter < animals.Length)
			{
				animals[counter] = animal;
				counter++;
			}
		}

		public Node<Animal> GetElderPredators()
		{
			Node<Animal> list = null;
			for (int i = 0; i < this.counter; i++)
			{
				if (this.animals[i].GetIsSuperPredator() && this.animals[i].GetAge() > 10)
					list = new Node<Animal>(this.animals[i], list);
			}
			return list;
		}

		public int CountSuperPredators()
		{
			int count = 0;
			for (int i = 0; i < this.counter; i++)
			{
				if (this.animals[i] is Reptile || this.animals[i] is Bird)
					count++;
			}
			return count;
		}
	}
}

using System;

namespace ZOO
{
	internal class Program
	{



		public static int TotaleCalories(Animal[] animels)
		{
			int sum = 0;
			for (int i = 0; i < animels.Length; i++)
			{
				sum += animels[i].Eat();
			}

			return sum;
		}






		public static void Birdsing(Animal[] animals)
		{
			for (int i = 0; i < animals.Length; i++)
			{
				if (animals[i] is Bird)
				{
					Console.WriteLine(animals[i].GetName() + "Singing");

					((Bird)animals[i]).Sing();

				}

			}

		}






		public static void AnimelDance(Animal[] animals)
		{
			for (int i = 0; i < animals.Length; i++)
			{
				if (animals[i] is Bird)
				{
					Console.WriteLine(animals[i].GetName() + " Dancing");
					((Bird)animals[i]).Dance();
				}
				else if (animals[i] is Snake)
				{
					Console.WriteLine(animals[i].GetName() + " Dancing");
					((Snake)animals[i]).Dance();
				}

			}
		}







		public static string FatHipo(Animal[] animals)
		{

			Hipo maxFat = null;

			for (int i = 0; i < animals.Length; i++)
			{

				if (animals[i] is Hipo)
				{
					if (maxFat == null || ((Hipo)animals[i]).GetfatPercentage() > maxFat.GetfatPercentage())
					{
						maxFat = (Hipo)animals[i];
					}

				}
			}
			return maxFat == null ? "" : maxFat.GetName();
		}


		static void Main(string[] args)
		{


			Animal c1 = new Animal("lion", 3, true, 5000);





			Console.WriteLine(new Park());









			Animal[] arr = new Animal[6];
			arr[0] = new Bird("bird1", 1, false, 5, 1000, 4);
			arr[1] = new Snake("snake1", 1, true, 400, 300, true);
			arr[2] = new Crocodile("Crocodile1", 2, false, 6, 1000, true);
			arr[3] = new Cow("cow1", 1, false, 1000, 1500, 6, 0);
			arr[4] = new Hipo("hipo1", 3, false, 2000, 1800, 8, 28);
			arr[5] = new Hipo("hipo2", 3, false, 2200, 1900, 8, 26);


			for(int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine(arr[i].Eat());
			}

			Console.WriteLine();
			Birdsing(arr);


			Console.WriteLine();
			AnimelDance(arr);


			Console.WriteLine();
			FatHipo(arr);





			Console.ReadKey();


		}
	}
}

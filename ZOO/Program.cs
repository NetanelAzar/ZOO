using System;

namespace ZOO
{
	internal class Program
	{
		static void Main(string[] args)
		{


			Animal c1 = new Animal("lion", 3, true, 5000);










		    static int TotaleCalories(Animal[] animels)
			{
				int sum = 0;
				for(int i = 0; i < animels.Length; i++)
				{
					sum += animels[i].Eat();
				}

				return sum;
			}






			static void Birdsing(Animal[] animals)
			{
				for(int i = 0; i < animals.Length; i++)
				{
					if (animals[i] is Bird)
				    {
						Console.WriteLine(animals[i].GetName() + "Singing");

						((Bird)animals[i]).Sing();

					}

				}
				
			}






			static void AnimelDance(Animal[] animals)
			{
				for(int i = 0; i < animals.Length; i++)
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







			static void FatHipo(Animal[] animals)
			{

				int maxFat =0;

				for(int i =0; i< animals.Length; i++)
				{

					if (animals[i] is Hipo)
					{
						Console.WriteLine(animals[i].GetName() + " fat Percentage");
						((Hipo)animals[i]).GetfatPercentage();
					}
				}
			}




			Console.ReadKey();


		}
	}
}

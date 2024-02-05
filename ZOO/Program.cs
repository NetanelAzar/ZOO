using System;

namespace ZOO
{
	internal class Program
	{
		static void Main(string[] args)
		{


			Animal c1 = new Animal("lion", 3, true, 5000);





			Console.WriteLine(new Park());




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







			static string FatHipo(Animal[] animals)
			{

				Hipo maxFat =null;

				for(int i =0; i< animals.Length; i++)
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




			Console.ReadKey();


		}
	}
}

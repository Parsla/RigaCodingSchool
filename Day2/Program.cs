using System;

namespace Day2
{
	class Program
	{
		static void Task1()
        {
			Console.WriteLine("Ievadi 1. skaitli: ");
			string userInput = Console.ReadLine();
			int x = Convert.ToInt32(userInput);

			Console.WriteLine("Ievadi 2. skaitli: ");
			string userInput2 = Console.ReadLine();
			int y = Convert.ToInt32(userInput2);

			if (x >= 20 && y >= 30 && y <= 50)
			{
				Console.WriteLine("Ievadīto skaitļu summa ir: " + (x + y));
			}
			else
			{
				Console.WriteLine("Ievadītajam skaitlim jābūt robežās no 0 līdz 20!");
				Console.WriteLine("Ievadītajam skaitlim jābūt robežās no 30 līdz 50!");
			}
		}
		static void Main(string[] args)

		{
			Task1();
		}
		
	}

}

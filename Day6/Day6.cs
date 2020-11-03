using System;

namespace Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr.: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            switch (x)
            {
                case 1:
                    Task1.PrintGreeting();
                    Task1.PrintGreeting();
                    Task1.PrintGreeting();
                    //for(int i = 0; i < 3; i++)
                    break;
                case 2:
                    string name = "Pārsla";
                    string surname = "Ēberliņa";
                    Task2.PrintMyName(name, surname);
                    break;
                case 3:
                    string nameSurname = Task3.GetNameSurname();
                    Task3.PrintNameSurname(nameSurname);
                    break;
                case 4:
                   
                    Console.Write("Ievadi skaitli n: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Faktoriāls no {n} ir {Task4.Factorial(n)}");
                    break;
                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 4!");
                    break;

            }
        }
    }
}

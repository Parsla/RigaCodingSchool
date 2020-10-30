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
                    break;
                case 2:
                    Task2.PrintMyName(string name, string surname);
                    /*Console.WriteLine(name + " " + surname);
                    Console.WriteLine((name.Substring(0, 1)) + ". " + (surname.Substring(0, 1).ToUpper()) + surname.Substring(1));*/
                    break;
                case 3:
                    string nameSurname = Task3.GetNameSurname();
                    Task3.PrintNameSurname(nameSurname);
                    break;
                case 4:
                    Task4();
                    break;
                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 4!");
                    break;

            }
        }
    }
}

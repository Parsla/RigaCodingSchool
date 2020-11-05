using System;
using System.Security.Cryptography.X509Certificates;

namespace Day7
{
    class Day7
    {
       
        
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr.: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            switch (x)
            {
                case 2:
                    Task2.PrintNameSurname("Pārsla Ēberliņa");
                    Task2.PrintNameSurname("Pārsla", "Ēberliņa");
                    Task2.PrintNameAge("Pārsla", 32);
                    Task2.PrintNameAge("Pārsla");
                    break;
                case 3:
                    int[] array = { 1, 2, 3 };
                    Task3.PrintArrayValues(array);
                    string[] stringArray = { "a", "b", "c" };
                    Task3.PrintArrayValues(stringArray);
                    break;
                case 4:
                    string[] nameArray = { "Jānis", " ", "Pēteris", "Antons", " ", "Andris" };
                    Task3.PrintArrayValues(nameArray);
                    nameArray = Task4.GetNonEmtyArray(nameArray);
                    Task3.PrintArrayValues(nameArray);
                   break;
               case 5:
                    Task5.CalculateSum(1, 2);
                    break;
                case 6:
                    //Task6();**//
                   // break;*/
                //default:
                    Console.WriteLine("Ievadi skatli robežās no 2 līdz 6!");
                    break;
            }
        }
    }
}

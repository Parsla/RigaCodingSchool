using System;

namespace Day8
{
    class Day8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr.: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            switch (x)
            {
                case 1:
                    int[] intArray = { 7, 2, 3, 4, 5, 6, 7 };
                    Task1.GetOnlySmallValues(intArray);
                    Console.WriteLine(String.Join(",", intArray));
                    intArray = Task1.GetOnlySmallValues(intArray);
                    Console.WriteLine(String.Join(",", intArray));
                    break;
                case 2:
                    Console.WriteLine(Task2.ValidatePassword("1234"));
                    Console.WriteLine(Task2.ValidatePassword("12345678"));
                    Console.WriteLine(Task2.ValidatePassword("12A34789"));

                    break;

                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 2!");
                    break;
            }
        }
    }
}

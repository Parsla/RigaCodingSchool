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
                    int[] intArray = { 1, 2, 3, 4, 5, 6, 7 };
                    Task1.GetOnlySmallValues(intArray);
                    break;
                case 2:

                    break;

                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 2!");
                    break;
            }
        }
    }
}

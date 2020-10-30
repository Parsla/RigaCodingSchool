using System;

namespace Day5
{
    class Day5
    {
        static void Task1()
        {

        }
        static void Task2()
        {

        }
        static void Task3()
        {

        }
        static void Task4()
        {

        }
        static void Task5()
        {

        }
        static void Task6()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi uzdevuma nr.: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            switch (x)
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
                case 6:
                    Task6();
                    break;
                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 6!");
                    break;

            }
        }
    }
}

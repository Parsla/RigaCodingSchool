using System;
using System.Security.Cryptography.X509Certificates;

namespace Day4
{
    class Day4
    {
        static void Task1()
        {
            string[] array = { "Jānis", "Pēteris", "Kārlis" };


            for (int i = 0; i < array.Length; i++)
            {

            }
        
        }
        static void Task2()
        {
            int[] numbers = { 1, 3, 4, 8, 0, 23 };
            string str = string.Join(" , ", numbers);
            Console.WriteLine(str);
            for (int i = 0; i < numbers.Length; i++)
            {
                while (i > 5)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

        }
        static void Task3()
        {
            string[] array = { "Jānis", "Pēteris", "Kārlis" };
            string str = string.Join(" , ", array);
            Console.WriteLine(str);
            for (int i = 0; i < array.Length; i++)
                if (array[i].StartsWith("J"))
                {
                    Console.WriteLine(str);
                }

            /*for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i);
            }*/
        }
        static void Task4()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
                Console.WriteLine(array[i]);
            }
        }
        static void Task5()
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
                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 5!");
                    break;

            }
        }
    }
}

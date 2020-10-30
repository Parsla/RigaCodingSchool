using System;

namespace Day3
{
    class Day3
    {
        static void Task1()
        {
            int[] array = { 1, 6, 7, 78, 9, 9 };
            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }

        static void Task2()
        {
            Console.Write("Vai Tu gribi pusdienas?");
            string userInput = Console.ReadLine();
            bool b = bool.Parse(userInput);

            if (b == true)
            {
                Console.WriteLine("Jūsu pusdienas ir gatavas!");
            }
            else
            {
                Console.WriteLine("Pusdienas nebūs!");
            }

        }
        static void Task3()
        {
            bool b = true;

            int i = 0;
            while (b)
            {
                if(++i == 20)
                {
                    b = false;
                    
                }
            }
        }
        static void Task4()
        {
            Console.Write("Ievadi skaitli, cik reizes jāatkārto for cikls! ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            for(int i = 0; i < x; i++)
            {
                Console.WriteLine("Hello, world!");
            }
        }
        static void Task5()
        {
            int[] array = { 100, 200, 233, 66, 77, 98 };
            Console.WriteLine(array[0]);
            Console.WriteLine(array[5]);
        }
        static void Task6()
        {
            int[] array = { 7, 4, 7, 3, 6, 9, 2 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3) 
                {
                    array[i] = 10;
                }
            }
            string str = string.Join(" , ", array);
            Console.WriteLine(str);
           
        }
        static void Task7()
        {
            string[] array = { "Jānis", "Pēteris", "Andris" };
            Console.WriteLine(array[1]);
            array[2] = "Jēkabs";
            string str = string.Join(" , ", array);
            Console.WriteLine(str);
        }
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Task8()
        {
            WeekDays days = WeekDays.Friday;
            Console.WriteLine(days);
        }
        
        static void Task9()
        {
            Console.WriteLine("Ievadi vienu skaitli: ");
            string userInput = Console.ReadLine();
            int x = Convert.ToInt32(userInput);

            while (userInput <= 20)

            /*if(x > 20)
            
                Console.WriteLine("Ievadītajam skaitlim jābūt mazākam par 20!");*/
            
           
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
                case 7:
                    Task7();
                    break;
                case 8:
                    Task8();
                    break;
                case 9:
                    Task9();
                    break;
                default:
                    Console.WriteLine("Ievadi skatli robežās no 1 līdz 9!");
                    break;
            }

            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();

        }

    }
}

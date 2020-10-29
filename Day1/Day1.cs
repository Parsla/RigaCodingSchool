using System;
using System.Text;


namespace Day1
{
    class Day1
    {
        static void Task1()
        {
            string str = "Pārsla Ēberliņa";
            Console.WriteLine(str);
            Console.WriteLine("Pārsla Ēberliņa");
        }
        static void Task2()
        {
            int x;
            string y;
            bool z = true;
            double e = 2.123;

            int a = 2 + 1;
            string b = "Text + " + a;
            bool c = true;
            double d = 5.123;

            Console.WriteLine("a = " + a + "; b = " + b + "; c = " + c + "; d = " + d);
        }
        static void Task3()
        {
            int x = 10;
            int y = 15;
            int z = x + y;

            Console.WriteLine("z = " + z);
        }
        static void Task4()
        {
            Console.Write("Ievadi vārdu: ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);
        }
        static void Task5()
        {
            Console.WriteLine("Ievadi savu vārdu: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Ievadi savu uzvārdu: ");
            string userSurname = Console.ReadLine();
            Console.WriteLine(userName + " " + userSurname);
            Console.WriteLine((userName.Substring(0, 1)) + ". " + (userSurname.Substring(0, 1).ToUpper()) + userSurname.Substring(1));
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

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
            }
            /*Task1();
            Task2();
			Task3();
			Task4();*/
            //Task5();
        }


    }
}

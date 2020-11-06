using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair chair1 = new Chair(100, "brown", 2);
            Chair chair2 = new Chair(110, "white", 3);
            Chair chair3 = new Chair(90, "green", 1);

            /*   Chair chair1 = new Chair();
               chair1.Heigth = 100;
               chair1.Color = "brown";
               chair1.Weigth = 2;

               Chair chair2 = new Chair();
               chair2.Heigth = 110;
               chair2.Color = "white";
               chair2.Weigth = 3;*/

            List<Chair> chairList = new List<Chair>();
            chairList.Add(chair1);
            chairList.Add(chair2);
            chairList.Add(chair3);


            int maxWeigth = chairList.Max(Chair => chair.Weigth);
            Chair mostExpensiveCar = chairList.Where(chair => chair.Weigth == maxWeigth).First();

            Console.WriteLine(mostExpensiveCar.GetString());

        }
    }
}

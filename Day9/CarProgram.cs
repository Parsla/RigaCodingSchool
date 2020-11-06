using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9
{
    class CarProgram
    {
        static void Main(string[] args)
        {
            Car volvo = new Car("Volvo", "XC 70", 60000, "Black", 2020);
            Car audi = new Car("Audi", "TT", 5000, "Green", 2010);
            Car bmw = new Car("BMW", "X5", 50000, "Red", 2018);

            List<Car> carList = new List<Car>();
            carList.Add(bmw);
            carList.Add(volvo);
            carList.Add(bmw);


            int maxPrice = carList.Max(Car => Car.price);
            Car mostExpensiveCar =  carList.Where(car => car.price == maxPrice).First();

            // Ja vēlas izvadīt vairākus auto ar vienādu augstāko cenu
           /* List<Car> mostExpensiveCar = carList.Where(car => car.price == maxPrice).ToList();
            foreach (Car car in mostExpensiveCar)
            {
                Console.WriteLine(car.GetString());
            }*/

            Console.WriteLine(mostExpensiveCar.GetString());

            Car expensiveCar = new Car();  
            foreach (Car car in carList)
            {
                if (car.price > expensiveCar.price)
                {
                    expensiveCar = car;
                }
            }
            Console.WriteLine(expensiveCar.GetString());

            /*Car volvo = new Car();
            volvo.make = "volvo";
            volvo.model = "xc 70";
            volvo.price = 60000;
            volvo.color = "black";
            volvo.year = 2020;
            Console.WriteLine(volvo.GetString());

            Car audi = new Car();
            audi.make = "audi";
            audi.model = "bc";
            audi.price = 50000;
            audi.color = "black";
            audi.year = 2000;
            Console.WriteLine(audi.GetString());

            Car bmw = new Car();
            bmw.make = "bmw";
            bmw.model = "X5";
            bmw.price = 40000;
            bmw.color = "black";
            bmw.year = 1000;
            Console.WriteLine(bmw.GetString());*/


        }
    }
}

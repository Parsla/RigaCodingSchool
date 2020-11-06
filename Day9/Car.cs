using System;
using System.Collections.Generic;
using System.Text;

namespace Day9
{
    class Car
    {
        //klases lauku definēšana
        public string make;
        public string model;
        public int price;
        public string color;
        public int year;

        public Car()
        {
            //noklusējums
        }

        public Car(string make, string model, int price, string color, int year)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.color = color;
            this.year = year;
          
        }

        public string GetString()
        {
            return $"{this.make}, {this.model}, {this.price}, {this.color}, {this.year}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    class Chair
    {
        public Chair(int heigth, string color, int weigth)
        {

        }
        public int Heigth { get; set; }
        public string Color { get; set; }
        public int Weigth { get; set; }

    }
    public string GetString()
    {
        return $"{this.heigth}, {this.color}, {this.weigth}";
    }
}

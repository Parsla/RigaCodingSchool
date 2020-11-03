using System;
using System.Collections.Generic;
using System.Text;

namespace Day7
{
    class Task3
    {
        public static void PrintArrayValues(int[] array)
        {
            
            string str = string.Join(" , ", array);
            Console.WriteLine(str);
        }
        public static void PrintArrayValues(string [] array)
        {
            
            string str = string.Join(" , ", array);
            Console.WriteLine(str);
        }
    }
}

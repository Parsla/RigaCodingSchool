using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day7
{
    class Task4
    {
        public static string[] GetNonEmtyArray(string[] array)
        {
            //return array.Where(item => !String.IsNullOrEmpty(item)).ToArray;
            List<string> list = new List<string>();
            foreach(string item in array)
            {
                if(!String.IsNullOrEmpty(item))
                {
                    list.Add(item);
                }
            }
            string[] nonEmptyArray = list.ToArray();
            return nonEmptyArray;
           
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Day8
{
    class Task1
    {
        public static void GetOnlySmallValues(int[] intArray)

        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i < 5)
                {
                    Console.WriteLine(intArray[i]);
                }

            }

        }


    }
}

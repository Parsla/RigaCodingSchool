using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Day8
{
    class Task2
    {
        public static bool ValidatePassword (string password)
        {

            if (password.Length >= 8)
            {
               /* bool isDigits = password.Any(symb => char.IsDigit(symb));
                bool isLetters = password.Any(symb => char.IsLetter(symb));
                return isDigits && isLetters;*/

                //+ Pārbaudām, vai ir skaitļi un burti
                bool isDigits = false;
                bool isLetters = false;
                foreach (char symbol in password)
                {
                    if (char.IsLetter(symbol))
                    {
                        isLetters = true;
                    }
                    else if (char.IsDigit(symbol))
                    {
                        isDigits = true;
                    }
                    if (isLetters && isDigits)
                    {
                        return true;
                    }
                }
            }
                return false;
                //Console.WriteLine("Password ok!"); 
            /*}
            return false;
            {
                //Console.WriteLine("Password must be atleast 8 characters!");
            }*/

           /* char[] charArray = userInput.ToCharArray();
            //char ch = userInput;
            for(int i = 0; i < charArray.Length; i++)
            {
                Console.WriteLine(Char.IsDigit(charArray[i]));
                Console.WriteLine(Char.IsLetter(charArray[i]));
            }*/
            
        }
            
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment
{//WAP to accept a character from user & check whether it is vowel or not
    internal class vowel
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a charecter");
            char ch = Convert.ToChar(Console.ReadLine());
            if ((ch == 'A') || (ch == 'a') || (ch == 'E' )|| (ch == 'e') || (ch == 'I') || (ch == 'i')|| (ch == 'O') || (ch == 'o') || (ch == 'U') || (ch == 'u'))
            {
                Console.WriteLine("This is vowel");
            }
            else
            {
                Console.WriteLine("This is not vowel");
            }
        }
    }
}

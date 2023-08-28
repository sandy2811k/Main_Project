using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{//uppercase or lowercase
    internal class Upperoolower
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter charecter");
            char ch=Convert.ToChar(Console.ReadLine());

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("This is lowercase charecter");
            }
            else if (ch >= 'A' && ch <= 'Z') 
            {
                Console.WriteLine("This is uppercase charecter");
            }
            else
            {
                Console.WriteLine("This is not charecter");
            }



        }
    }
}

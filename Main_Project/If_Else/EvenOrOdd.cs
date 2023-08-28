using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnement_2_hw
{ //Write a program to input a number and check whether its even or odd.

    internal class EvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("odd");
            }
            
            
        }
    }
}

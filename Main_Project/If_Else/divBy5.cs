using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingnement_2_hw
{
    internal class divBy5
    { //Write a program to input a number and check whether it is greater than 5 or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num>=5)
            {
                Console.WriteLine("It is greater than 5");

            }
            else
            {
                Console.WriteLine("Not greater than 5");
            }
        }
    }
}

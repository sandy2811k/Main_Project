using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{    
    // find max bet three numbers
    internal class PositiveNegative
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number ");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number");
            int num2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd number");
            int num3=Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("1st number is greater");
            }
            else if(num2 >= num3)
            {
                Console.WriteLine("2nd number is greater");
            }
            else 
            {
               Console.WriteLine("3rd number is greater ");
            }


        }
    }
}

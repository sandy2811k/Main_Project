using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Greater_No_Bet_3
    { //Write a C# program to find maximum between three numbers (using logical operator)


        static void Main(string[] args)
        {
            Console.Write("Enter 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"number 1st is greater it is : {num1}");
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"number 2nd is greater it is : {num2}"); 
            }
            else
            {
                Console.WriteLine($"number 3rd is greater it is : {num3}");
            }


        }
    }
}

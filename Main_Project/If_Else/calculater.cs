/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class calculater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter your choice:1,2,3,4");

            int choice=Convert.ToInt32(Console.ReadLine());
            double result = 0;
            switch (choice)
            {
                    case 1:
                    result=num1 + num2;
                    Console.WriteLine("addition is :" + result);
                    break;

                    case 2:
                    result=num1 - num2;
                    Console.WriteLine("subtraction is :" + result);
                    break;

                    case 3:
                    result=num1 * num2;
                    Console.WriteLine("multipication is :"+result);
                    break; 

                    case 4:
                    result=num1 / num2;
                    Console.WriteLine("division is :" +result);
                    break;
                    


            }


        }
    }
}
*/
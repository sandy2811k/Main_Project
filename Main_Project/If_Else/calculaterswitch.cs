using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class class3
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter two numbers");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Menu:");
            
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Mod");
            Console.WriteLine("Enter your choice:1,2,3,4,5");


            int choice=Convert.ToInt32(Console.ReadLine());
            double result = 0;

            switch (choice)
            {
                case 1:
                     result= num1 + num2;
                    Console.WriteLine("result for addition:" + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("result for subtraction:" + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("result for multiplication:" + result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("result for division:" + result);
                    break;
                case 5:
                    result = num1 % num2;
                    Console.WriteLine("result for mod:" + result);
                    break;

                 default: Console.WriteLine("invalid choice");
                    break;
                }
        }
    }
}

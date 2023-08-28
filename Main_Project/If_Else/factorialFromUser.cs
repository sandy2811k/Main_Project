using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class factorialFromUser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for(int i = 1; i <= num;i++)
            {
                fact= fact*i;

            }
            Console.WriteLine("factorial of given number :" + fact);
        }
    }
}

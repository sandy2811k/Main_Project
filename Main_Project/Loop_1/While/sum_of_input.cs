using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{
    internal class sum_of_input
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 Digit Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;

            }
            Console.WriteLine("Sum of given number is:" + sum);
        }
    }
}

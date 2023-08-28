using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_level
{
    internal class primeOrNotprime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    a = 0;
                    break;
                }
            }
                if (a == 0)
                {
                    Console.WriteLine("not prime");
                }
                else
                {
                    Console.WriteLine("prime");
                }
            

        }
    }
}

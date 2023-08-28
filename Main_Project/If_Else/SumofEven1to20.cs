using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class SumofEven1to20
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
                if (i % 2 == 0)
                {
                    sum += i;
                    Console.WriteLine($"Even number from 1 to 20 :"+i);
                }
                Console.WriteLine($"Sum of Even number from 1to 20 :"+sum);
            
        }
    }
}

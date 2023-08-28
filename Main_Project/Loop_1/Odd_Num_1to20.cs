using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Odd_Num_1to20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd number between 1 to 20:");

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

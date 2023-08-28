 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.For_Loop
{
    internal class Prime_N0_11to21
    {
        static void Main(string[] args)
        { 
            for (int i = 11; i <= 21; i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) 
                    {
                        isprime = false;
                        break;
                    }
                }
                if(isprime==true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

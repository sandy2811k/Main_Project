using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time
{
    internal class CalSumOfPrime
    { //WAP to calculate sum of Prime number between 1 to 20 
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1;i<=20;i++)
            {
                bool isprime = true;
                for (int j = 2; j < i; j++)
                {                  
                    if (i% j==0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    sum = sum + i;
                }                
            }
            Console.WriteLine(sum);
        }
    }
}

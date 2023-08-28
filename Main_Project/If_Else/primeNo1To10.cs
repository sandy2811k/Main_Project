using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class primeNo1To10
    {
        static void Main(string[] args)
        {
             //print 1to 10 numbers
               
             Console.WriteLine("Prime Numbers between 1 To 10: ");

             for(int num=1; num<=10;num++)
             { bool isprime = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                    if (isprime == true)
                    {
                        Console.WriteLine(num);
                    }
                
             }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time
{
    internal class SumOfEvenDig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum=0;

            while(num>0)
            {
                int rem = num % 10;

                if(rem%2==0)
                {
                    sum = sum + rem;
                }
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}

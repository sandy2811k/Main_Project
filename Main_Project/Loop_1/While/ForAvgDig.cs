using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class ForAvgDig
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            int rem=0;
            int cnt=0;

            while(num!=0)
            {
                rem = num % 10;
                sum = sum + rem;
                cnt++;
                num = num / 10;

            }
            double avg = (double)sum / cnt;
            Console.WriteLine(avg);
            

        }
    }
}

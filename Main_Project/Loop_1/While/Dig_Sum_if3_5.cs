using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time
{
    internal class _1st_and_last_digit_sum
    {
        static void Main(string[] args)
        {
            int sum = 0, fd, ld;  
            int num = 0;
            Console.WriteLine("Enter a number");
            num=Convert.ToInt32(Console.ReadLine());
            ld = num % 10;
            fd = num;
            while(num>=10)
            {
                num = num / 10;
            }
            fd= num;
            sum = fd + ld;
            Console.WriteLine(sum);

        }
    }
}

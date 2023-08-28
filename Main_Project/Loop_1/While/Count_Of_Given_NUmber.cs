using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{
    internal class Count_Of_Given_NUmber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            while(num!=0)
            {
                int rem = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine($"Count is:"+count);
        }
    }
}

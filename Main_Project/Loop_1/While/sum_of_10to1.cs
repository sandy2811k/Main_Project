using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{ //calculate Sum of 10 to 1 number
    internal class sum_of_10to1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 10 to 1 number :");
            int i = 10;
            int sum = 0;
            while (i >= 1)
            {
                sum = sum + i;

                i--;
            }
            Console.WriteLine(sum);

        }
    }
}

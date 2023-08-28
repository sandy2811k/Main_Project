using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Sum_of_10to1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate Sum of 10 to 1 number :");

            int sum = 0;
            for (int i=10;i>=1;i--)
            {
               
                sum = sum + i;
                
            }
            Console.WriteLine(sum);

        }
    }
}

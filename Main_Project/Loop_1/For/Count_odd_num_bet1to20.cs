using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.For_Loop
{
    internal class Count_odd_num_bet1to20
    { // count how many odd number between 1 to 20
        static void Main(string[] args)
        {
            Console.WriteLine("count how many Odd numbers between 1 to 20 ");
            int count = 0;
            for (int i = 1; i <= 20; i++)
                if (i % 2 != 0)                     //use (i%2!=0) for odd number 
                {
                    count++;
                }
            Console.WriteLine(count);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{ //Display number between 1 to 20 which divisible by 5
    internal class Num_Bet_1to20_div_by5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}

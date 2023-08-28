using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{ // Display od number between 1to 20
    internal class odd_num_bet_1to20
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd number between 1 to 20:");

            int i = 1;
            while (i <= 20)
            { 
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);

                }

                i++;
            }
        }
    }
}

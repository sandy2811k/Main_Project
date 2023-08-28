using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{ //Display number bet 21 to 30
    internal class Num_bet_21to30
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number between 21 to 30:");

            int i = 21;
            while (i <= 30)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}

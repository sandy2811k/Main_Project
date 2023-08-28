using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{ //Display number between 45 to 25
    internal class Num_Bet_45to25
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number between 45 to 25:");

            int i = 45;
            while (i >= 25)
            {
                Console.WriteLine(i);
                i--;
            }

        }
    }
}

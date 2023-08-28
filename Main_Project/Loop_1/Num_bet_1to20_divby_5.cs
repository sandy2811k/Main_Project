using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Num_bet_1to20_divby_5
    { //display Number 1 to 20 which are div by 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Number between 1 to 10 which are div by 5:");

            for(int i=1;i<=20;i++)
            {
                if (i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}

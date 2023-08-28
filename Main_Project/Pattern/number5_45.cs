using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class number5_45
    {
        /*54321
         * 5432
         * 543
         * 54
         * 5*/

        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j);

                }
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class WhileDivBy3and5
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                i++;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
    }
}

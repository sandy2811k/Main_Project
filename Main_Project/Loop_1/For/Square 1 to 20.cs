using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time
{
    internal class square_1_to_20
    {
        static void Main(string[] args)
        {
            int su = 1;
            for (int i = 1; i <= 20; i++)
            {
                su = i * i;
                Console.WriteLine(su); 
            }
        }
    }
}

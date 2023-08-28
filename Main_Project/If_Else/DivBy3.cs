using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.If_Else
{
    internal class DivBy3
    {
        static void Main(string[] args)
        {
            int Result = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

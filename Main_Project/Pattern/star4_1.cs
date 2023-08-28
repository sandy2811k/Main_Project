using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class star4_1
    {  /*
        
        ****
        ***
        **
        *
        
        */
        
        static void Main(string[] args)
        {
            for(int i=4;i>=1;i--)
            {
                for(int j=1;j<=i;++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

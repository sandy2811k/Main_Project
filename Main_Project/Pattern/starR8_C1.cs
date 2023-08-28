using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class starR8_C1
    { /*
        ********  //row=8
        *******   //7
        ******    //6
        *****
        ****
        ***
        **
        *         //row=1
        col=1
        */
        static void Main(string[] args)
        {
            for(int row = 8; row >= 1;--row) 
            {
              for(int col=1;col<=row;++col)
                {
                    Console.Write("*");
                }
              Console.WriteLine();
            }    
        }
    }
}

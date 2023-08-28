using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class starR1C8
    {
        /*
         
         *         row=1
         **           =2
         ***
         ****
         *****
         ******
         *******
         ******** 
         col=8
         
         */
        static void Main(string[] args)
        {
            for(int row=1;row<=8;row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class number1
    {
        static void Main(string[] args)
        /*1
         * 12
         * 123
         * 1234
         * 12345
         * */
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1 ;j<=i; j++)
                {
                    Console.Write(j);
                }
               Console.WriteLine();
            }
        }
    }
}

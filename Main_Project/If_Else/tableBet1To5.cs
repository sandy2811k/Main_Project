using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class tableBet1To5
    {// table between 1to 5 :

        static void Main(string[] args)
        {
            Console.WriteLine("Table between 1 to 5:");
            int num = 5;
            int result=1;

            for (num = 1; num <= 5; num++)

            {
                Console.WriteLine();


                for (int i = 1; i <= 10; i++)
                {
                     result =  num * i;

                    Console.WriteLine($"{num}*{i}={result}");
                 }
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class LoopEven
    {//print even number 1 to100 
        static void Main(string[] args)
        {
            {
                for (int i = 1; i <= 100; i++)
                {
                    switch (i % 2)
                    {
                        case 0:
                            Console.WriteLine(i); 
                            break;


                    }



                 }
            }
        }
    }
}

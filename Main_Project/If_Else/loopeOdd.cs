using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{//Print odd number from 1- 50 
    internal class Loop3
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=50;i++)
            if (i%2==1)
            {
                Console.WriteLine(i);
            }
        }
    }
}

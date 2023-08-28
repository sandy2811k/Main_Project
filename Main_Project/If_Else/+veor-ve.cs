using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class _veor_ve
    {  //WAP to accept a number from the user & check number is +ve or -ve or zero
        static void Main(string[] args)
        {
            Console.Write("Enter any number:");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num<0)
            {
                Console.WriteLine("-ve");
            }
            else if(num>0) 
            {
                Console.WriteLine("+ve");
            }
            else { Console.WriteLine("zero");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ANumber
    {//WAP to accept a number from the user & check number is +ve or -ve or zero.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            if(num <0) 
            {
                Console.WriteLine("-ve");
            }
            else if(num == 0) 
            {
                Console.WriteLine("zero");
            }
            else
            {
                Console.WriteLine("+ve");
            }
        }
    }
}

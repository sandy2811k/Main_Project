using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assingnement_2_hw
{
    internal class prime2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());

            int num2 = num;
            int n=0;



            while (num2 != 0)
            {
                num2 = num2 / 10; //number of digits
                n++; 
            }
            Console.WriteLine(n);


           /* for(int i=0;i<num;i++)
            {
                dig = num2  % 10; //
                num2 = num2 / 10;
                
                Console.WriteLine( num2);*/

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class find_even
    {
        static void Main(string[] args)
        {//
            
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++) 
            {
                Console.Write($"Enter {i} value: ");
                num[i] =Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < num.Length; i++)
                if (num[i] % 2 == 0)       //Even value
                {
                    Console.WriteLine($"Even values from input  = {num[i]}"); 
                }

                
        }
    }
}

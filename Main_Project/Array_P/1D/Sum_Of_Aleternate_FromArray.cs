using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class Sum_Of_Aleternate_FromArray
    { // calculate the sum of alternate element from array
        static void Main(string[] args)
        {
            int[] Array = { 1, 2,3,4,5};
            int sum = 0;
            for (int i = 0; i < Array.Length; i += 2)
            {
                    sum = sum + i;                
            }
            Console.WriteLine($"Sum Of Alternate Elements is:{sum}");

            Console.ReadLine();
        }
    }
}

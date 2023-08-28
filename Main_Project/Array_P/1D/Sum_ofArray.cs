using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class Sum_ofArray
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, };
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
                
            {
               sum = sum + i;
            }
            Console.WriteLine($"sum of array:{sum}");
            Console.ReadLine();
        }
    }
}

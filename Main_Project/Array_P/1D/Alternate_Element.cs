using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{ //Alternate Number From Array
    public class Alternate_Element
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

            for (int i = 0; i < Array.Length; i+=2)
            {
                {
                    Console.WriteLine($"Alternate Numbers:{Array[i]}");
                }
            }Console.ReadLine();    
        }
    }
}

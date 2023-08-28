using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class Cal_Sum_of_Even_Array
    { //Integer type of array and calculate the sum of even elemnt fron array
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11,12 };
            int sum = 0;

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    sum = sum + Array[i];
                }
            }
            Console.WriteLine($"Sum of Even Element:{sum}");
            Console.ReadLine();
        }
    }   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Array_1._1D_Array
{  //WAP to print all negative elements in an array and also count total number of negative elements in an array
    public class Negative_Element
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int Count=0;
            for(int i=0; i<array.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {                    
                    Console.WriteLine($"Negative number is :{array[i]}");
                    Count++;
                }               
            }
            Console.WriteLine($"Total Negative Numbers are:{Count}");
            Console.ReadLine();
        }   
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class max_min
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter numbers: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            } 
            int m = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > m)
                {
                    m = array[i];
                }
            }
            Console.WriteLine($"Max number:"+m);
            int n = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < n)
                {
                    n = array[i];                   
                }
                
            }Console.WriteLine($"Min Number:"+n);
        }
        
    }
}


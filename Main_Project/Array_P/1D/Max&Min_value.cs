using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1._1D_Array
{ //WAP to find the maximum and minimum value in an array.
    public class Max_Min_value
    {
        static void Main(string[] args)
        {   
            int[] array = new int[4];
            int max = array[0];
            int min = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < array.Length;i++)
                
            if (array[i] >= max)
            {  
                Console.WriteLine($"Maximum Number:{array[i]}");
            }
            else 
            {
                Console.WriteLine($"Minimum Number:{array[i]}");
            }
            Console.ReadLine();
        }
    }
}

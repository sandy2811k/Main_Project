using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1._1D_Array
{ //WAP to put even and odd elements of array in two separate arrays.
    public class Even_Odd
    {
        static void Main(string[] args)
        {
            int[] array=new int[10];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine($"Even Number:{array[i]}");
                }
                else
                {
                    Console.WriteLine($"odd Number:{array[i]}");
                }
            }Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1._1D_Array
{ //1.	WAP to search for a given number in an array and accordingly print the index if exists
    public class Search_Number
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter a Number");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter a Number To Search");
            int num=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine($"{num} found at {i} Index ");
                }

            }
            Console.ReadLine();

        }
    }
}

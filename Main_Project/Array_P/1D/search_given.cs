using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class search_given
    {
        static void Main(string[] args)
        {
            
            int[] array =new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a numbers: ");
                array[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Enter value for search:");
            int num=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
                if (array[i] == num)
                {
                    Console.Write($"{num} Found at {i}");
                }
                //else
               // {
               //     Console.Write("Not found");
               // }
        }
    }
}

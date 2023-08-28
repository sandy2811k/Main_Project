using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1._1D_Array
{ //WAP to show sum of even elemet compare 
    public class Sum_Even
    {
        static void Main(string[] args)
        {
            int sum=0;
            int[] array = new int[5];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter Number");
                array[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < array.Length;i++)
                if (array[i]%2== 0)
                {
                     sum = sum + array[i];

                   
                }
            Console.WriteLine($"Sum of even number :{sum}");
            Console.ReadLine();

        }
    }
}

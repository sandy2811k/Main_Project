using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.Generic
{ //WAP to create jagged array, initialized data & display the details

    internal class JaggedArr_InitizedData
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[4][];
            arr[0]=new int[] {1,2,3,4};

            arr[1]=new int[] {10,20,30};
            arr[2] = new int[] { 100, 200 };
            arr[3] = new int[] { 1000 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine(arr[i][j]);
                }
                Console.WriteLine("\n");
            }

            

            
        }
    }
}

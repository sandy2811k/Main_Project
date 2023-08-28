using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Count
    {
        static void Main(string[] args)
        { //WAP to Get 10 values from user and find negative numbers and there count.
            int[] num=new int[10]; //variable declear
            int count = 0;
            for (int i = 0; i < num.Length; i++) //
            {
                Console.WriteLine($"Enter {i} value: ");
                num[i] =Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < num.Length; i++) //use for loop
                if (num[i]<0)                    //find -ve number {num<0}
                {
                    count++;
                    Console.WriteLine($"Negative numbers from input are {num[i]}");
                }
            Console.WriteLine($"Total Negative Numbers:{count}"); //count
        }
    }
}

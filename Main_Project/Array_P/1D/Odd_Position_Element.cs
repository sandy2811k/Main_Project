using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class Odd_Position_Element
    {  //To create array and display odd position element from array
        static void Main(string[] args)
        {
            int[] Array = new int[10];

            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine("Enter a Number:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i]%2!=0)
                {
                    Console.WriteLine($"Odd Element:{Array[i]}");

                }
            }Console.ReadLine();
          
        }
    }
}

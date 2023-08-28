using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{ // 
    public class Search_FromArray
    {
        static void Main(string[] args)
        {
            int count=0;
            int[] Array = new int[6];
            for (int i = 0; i < Array.Length; i++) 
            {
                Console.Write("Enter a number:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            {
                Console.WriteLine("Search Number in Array:");
                int Search = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == Search)
                    {
                        count++;
                       
                    }                   
                }
                if (count > 0)
                {
                    Console.WriteLine($"Number Search in Array");
                }
                else
                {
                    Console.WriteLine("Given Number is Not Found in Array");
                }
                Console.ReadLine();
            }
        }
    }
}

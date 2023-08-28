using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public class Prime_FromArray
    { //Prime Number From Array
        static void Main(string[] args)
        {
            int[] Array =new int[5];
            for (int i = 0; i < Array.Length; i++)
            {
               Console.WriteLine("Enter Number:");
               Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i< Array.Length; i++)
            {
                bool isprime = true;
                for (int j = 2; j < Array[i]; j++)
                {
                    if (Array[i] % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                {
                    Console.WriteLine($"Prime Number From Array:{Array[i]} ");
                }
            }Console.ReadLine();
        }
    }
}

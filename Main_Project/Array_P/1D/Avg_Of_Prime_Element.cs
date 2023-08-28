using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Array_
{
    public class Avg_Of_Prime_Element
    {
        static void Main(string[] args)
        {
            int[] Array=new int[6];
            int Sum = 0;
            int Avg = 0;
            int count2 = 0;


            for (int i = 0; i < Array.Length; i++) 
            {
                Console.WriteLine("Enter Element:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i <Array.Length;i++) 
            { int count = 0;
                for (int j = 2; j < Array.Length; i++)
                {
                    if (Array[i]%j==0)
                    {  count++;
                        break;
                    }
                }
                if(count==0)
                {
                    Sum = Sum + Array[i];
                    count2++;
                }
            }
            Avg = Sum/count2;
            Console.WriteLine("Average Of Prime Number :" + Avg);
        }
    }
}

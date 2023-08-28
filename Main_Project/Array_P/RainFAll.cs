using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class RainFAll
    {
        static void Main(string[] args)
        {
            int[] week = new int[7];
            for (int i = 0; i <week.Length; i++)
            {
                Console.Write($"Enter Rain fall for day{i}");
                week[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Rain fall for a week is");

            for (int i = 0; i < week.Length; i++)
            {
                Console.Write($"DAy[{i}]={week[i]}");
            }

        }
    }
}

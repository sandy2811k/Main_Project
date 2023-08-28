using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class rainFall_For_Week
    {
        static void Main(string[] args)
        {
            int[] week = new int[7];
            for (int i = 0; i < 7; i++)
            {
                week[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Rain fall for a week is");

            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine($"week[{i}]={week[i]}");
            }

        }

    }
}

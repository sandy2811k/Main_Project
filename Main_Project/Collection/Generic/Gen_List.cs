using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection
{
    internal class Gen_List
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);

            list.Insert(1, 11);
            list.AddRange(arr);

            list.Remove(2);
            list.RemoveAt(0);
            list.RemoveRange(1,2);
            Console.WriteLine("Total count"+list.Count);

            list.Sort();
            list.Reverse();

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}

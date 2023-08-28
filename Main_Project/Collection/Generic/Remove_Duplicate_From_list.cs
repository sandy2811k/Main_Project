using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.Generic
{ //Create a list and remove duplicate form list
    internal class Remove_Duplicate_From_list
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(10);
            list.Add(20);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(40);
            list.Add(50);
            list.Add(20);
           
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
             
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        list.Remove(list[j]);
                        j--;
                    }
                }
            }
            Console.WriteLine("Answer After Remove Duplicate:");
            foreach (int i in list)
            {

                Console.WriteLine(i);
            }
        }
    }
}

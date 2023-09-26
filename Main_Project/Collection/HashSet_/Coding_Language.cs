using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.HashSet_
{
    internal class Coding_Language
    {
        static void Main(string[] args)
        {
            HashSet<string> list1 = new HashSet<string>();
            list1.Add("C");
            list1.Add("C#");
            list1.Add("python");
            list1.Add("Java");

            HashSet<string> list2 = new HashSet<string>();
            list2.Add("C");
            list2.Add("angular");
            list2.Add("C++");
            list2.Add("python");

           // Combine the result &Display unique elements
           // list1.Union(list2);
           // 
           // list1.IntersectWith(list2);
           //
            list1.ExceptWith(list2);

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}    
    


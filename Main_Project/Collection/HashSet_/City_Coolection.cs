using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.HashSet_
{
    internal class City_Coolection
    {
        static void Main(string[] args)
        {
            HashSet<string> list1 = new HashSet<string>();

            list1.Add("Pune");
            list1.Add("Ahemednagar");
            list1.Add("Mumbai");
            list1.Add("Delhi");


            //list1.Clear(); //clar all data

            list1.Remove("Delhi"); //remove this name from list

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.Generic
{
    internal class Stud_Sort
    { //WAP to create an array of 5 strings to store students name, sort names in ascending order & display using foreach loop.

        static void Main(string[] args)
        {
            Console.WriteLine("5 Strings:");
            List <string> list = new List <string>();
            list.Add("Sandesh");
            list.Add("Chidanad");
            list.Add("Shubham");
            list.Add("Rohit");
            list.Add("Aditya");


            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
                
            list.Sort();
            Console.WriteLine();

            Console.WriteLine("Assending orders:");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }


        }
    }
}

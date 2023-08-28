using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{ // Write a C# program to count total number of words in a string. 
    internal class Count_Tot_Num_Of_Words
    {
        static void Main(string[] args)
        {
            string str = "India Is The Best County";
            string[] strarray = str.Split(' ');

            int count = strarray.Length;

            Console.WriteLine(count);
        }
    }
}

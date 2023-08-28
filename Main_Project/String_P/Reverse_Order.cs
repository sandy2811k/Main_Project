using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{ // Write a C# program to reverse order of words in a given string.
    internal class Reverse_Order
    {
        static void Main(string[] args)
        {
            string str = "All The Best Students";
            string[] str1=str.Split(' ');
            string word = " ";

            for(int i=str1.Length-1; i>=0; i--)
            {
                word=word+" " + str1[i];
            }
            Console.WriteLine(word); //Students Best The All
        }
    }
}

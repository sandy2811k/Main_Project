using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{ // Write a C# program to find reverse of a string.
    internal class Reverse_Char
    {
        static void Main(string[] args)
        {
            string str = "Welcome In Pune";
            string str1=" ";

            for (int i = str.Length-1; i >=0;i--)
            {
                 str1 = str1 + str[i];
            }
            Console.WriteLine($"Main String:{str}\nReverse String:{str1}");
        }
    }
}

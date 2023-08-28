using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{
    internal class Count_Occurance_Of_Char
    { //Write a C# program to count occurrences of a character in given string.
        static void Main(string[] args)
        {
            string str = "Good Morning";
            int count = 0;

            for(int i = 0; i <str.Length; i++)
            {
                if (str[i] =='o' )
                {
                    count++;
                }
            }
            Console.WriteLine("Count:"+count);


        }
    }
}

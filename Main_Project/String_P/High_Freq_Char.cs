using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{
    internal class High_Freq_Char
    { //Write a C# program to find highest frequency character in a string.
        static void Main(string[] args)
        {
            string str = "Good Morning Everyone";
            string[] str1 = str.Split(' ');
            int count = 0;
            int max = 0;
            string str2 = "";

            for(int i = 0; i < str1.Length; i++)
            {
                count = str1[i].Length;
                if(count>max)
                {
                    max= count;
                    str2 = str1[i];
                }               
            }
            Console.WriteLine($"Highest Frequency Character in string:- {str2} ,Count:{max}");
        }    
    }
}

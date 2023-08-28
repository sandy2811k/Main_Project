using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{ // Write a C# program to find total number of alphabets, digits or special character in a string
    internal class Find_Tot_Alphabet_Dig_SChar
    {
        static void Main(string[] args)
        {
            string str = "dfvt12442/.,;'[";
            
            int count_Alphabet = 0; 
            int count_Dig = 0;
            int count_Sc = 0;
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if ((ch[i] >='A'&& ch[i] <= 'Z') || (ch[i] >= 'a' && ch[i]<='z'))
                {
                    count_Alphabet++;
                }
                else if (ch[i] >='0'&& ch[i]<='9')
                {
                    count_Dig++;
                }
                else 
                {
                    count_Sc++;
                }
                
            }
            Console.WriteLine($"Alphabet Count:{count_Alphabet},Digit Count:{count_Dig},Special Char Count:{count_Sc}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{
    internal class Count_Vowel_Consonants
    { //Write a C# program to count total number of vowels and consonants in a string.
        static void Main(string[] args)
        {
            int count_v = 0;
            int count_c = 0;
            string str = "Sandesh";
            char[] ch = str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == 'A' || ch[i] == 'E' || ch[i] == 'I' || ch[i] == 'O' || ch[i] == 'U' ||
                    ch[i] == 'a' || ch[i] == 'e' || ch[i] == 'i' || ch[i] == 'o' || ch[i] == 'u') 
                {
                    count_v++;
                }
                else
                {
                    count_c++;
                }
            }
            Console.WriteLine($"Vowel are :{count_v},Consonant are:{count_c}");
        }
    }
}

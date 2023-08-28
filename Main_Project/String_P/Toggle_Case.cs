using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_
{ //Write a C# program to toggle case of each character of a string.
    internal class Toggle_Case
    {
        static void Main(string[] args)
        {
            string str = "Sandesh";
            char[] ch =str.ToCharArray();
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] >= 65 && ch[i] <= 90)
                {
                    int a = (int)ch[i] + 32;
                    ch[i] = (char)a;
                }
                else
                {
                    int A = (int)ch[i] - 32;
                    ch[i] = (char)A;
                }                
            }
            string str1=new string(ch);
            Console.WriteLine(str1); //sANDESH
        }
    }
}

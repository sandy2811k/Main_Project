using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Exception_Handling
{ //WAP to check String content only alphabets if any digit or symbol is present then throw custom exception
    internal class String_alphabet_only
    {
        static void Main(string[] args)
        {
            try 
            {
                string str = "Sandesh@123456";
                char[] strobj = str.ToCharArray();
                 
                for(int i = 0; i < strobj.Length; i++)
                {
                    if (strobj[i] <= 'A' || strobj[i]>='Z'&& strobj[i] <= 'a' || strobj[i] >= 'z')
                    {
                        throw new NameException(" ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

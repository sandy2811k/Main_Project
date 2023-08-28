using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.If_Else.Convert_LowToUpper
{
    internal class Convert_LowToUpper_
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
                Console.WriteLine("this is upper character");
            }
            else if (ch >= 'a' && ch <= 'z')
            {
                ch = (char)(ch - 32);
                Console.WriteLine("This is lower character");
            }
            else
            {
                ch = ch;
                Console.WriteLine("Not character");
            }
        }
    }
}

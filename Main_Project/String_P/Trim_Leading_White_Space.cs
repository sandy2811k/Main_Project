using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{ // Write a C# program to trim leading white space characters in a string.
    internal class Trim_Leading_White_Space
    {
        static void Main(string[] args)
        {
            string str = "Sandesh ";
            string str2 = " Kshirsagar ";

            Console.Write(str.TrimEnd());        //Trim Space end if Sandesh_ --> Sandesh
            Console.WriteLine(str2.TrimStart()); //Trim Space front of _ksirsagar--> Kshirsagar
        }
    }
}

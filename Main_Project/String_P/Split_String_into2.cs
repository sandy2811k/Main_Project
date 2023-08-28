using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.String_P
{
    internal class Split_String_into2
    {
        static void Main(string[] args)
        {

            string str = "HELLO$WORLD";
           // char[] ch=str.ToCharArray();

            string[] chlist =str.Split('$');

            foreach (string ch in chlist)
            {
                Console.WriteLine(ch);
            }
        }
    }
}

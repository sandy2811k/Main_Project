using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunction
{
    internal class IsNullOrEmpt
    {
        static void Main(string[] args)
        {  //IsNullOrEmpty-->to check whether string has empty of null

            //string str=Null;Null means nothing,no space,no"",not empty

            string str = "";//empty -->no space ,it is not null.
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("String is empty");
            }
            Console.WriteLine(str);

            Console.Write("Enter a Name: ");
            string name=Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is reqired");
            }
            else 
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}

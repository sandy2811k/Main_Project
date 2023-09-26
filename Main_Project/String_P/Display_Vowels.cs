using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Array_
{
    public class Display_Vowels
    { //Display all the vowels from the array
        static void Main(string[] args)
        {
            string str = "Welcome To Think Quotiont";
            char[] strobj = str.ToCharArray();
            int count = 0;

            for(int i = 0; i < strobj.Length; i++)
            {
                if (strobj[i] == 'A' || strobj[i] == 'E' || strobj[i] == 'I' || strobj[i] == 'O' || strobj[i] == 'U'||
                    strobj[i] == 'a' || strobj[i] == 'e' || strobj[i] == 'i' || strobj[i] == 'o' || strobj[i] == 'u')
                {  count++; 
                }
            }
            Console.WriteLine($"Number of Vowels in Sentence:{count}");
            Console.ReadLine();
        }
    }
}

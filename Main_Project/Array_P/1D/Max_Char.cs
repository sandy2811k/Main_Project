using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Array_
{
    public class Max_Char
    {
        static void Main(string[] args)
        {
            string str = "Good Morning";
            char[] ch=str.ToCharArray();
            char max = ch[0];

            for (int i=0;i<ch.Length; i++)
            {
                if (ch[i] > max)
                {
                    max= ch[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}

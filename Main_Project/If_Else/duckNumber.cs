using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class duckNumber
    {
        static void Main(string[] args)
        { //duck number ir not duck number
            Console.WriteLine("Enter a number:");
            int num=Convert.ToInt32(Console.ReadLine());
            int cnt = 0;

            while (num != 0)
            {
                int rem = num % 10;

                if (rem == 0)
                {
                    cnt++;
                }
                num = num / 10;
            }
            Console.WriteLine(cnt);
            if(cnt == 1)
            {
                Console.WriteLine("number is duck number");
            }
            else
            {
                Console.WriteLine("number is not duck number ");
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Time
{
    internal class Reverse_Palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int rev = 0;

            while(num > 0) 
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            
            if (temp==rev)
            {
                Console.WriteLine("Palindrom");
            }
            else 
            {
                Console.WriteLine("Not Palindrom");
            }

        }
    }
}

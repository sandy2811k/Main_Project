using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class palindrom
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Palindrom number:");//eg..121,232,343,4554
            int num=Convert.ToInt32(Console.ReadLine());
            int r;
            int sum = 0;
            int temp = num;

            while( num>0)

            {
                r = num % 10;
                sum=(sum*10)+r;
                num/=10;

            }
            if (temp == sum)

            {
                Console.WriteLine("Number is palindrome");
            }
            else
            {
                Console.WriteLine("Number is not palindrome");
            }

           


        }
    }
}

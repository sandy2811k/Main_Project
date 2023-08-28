using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class EvenFromGiven
    { //to display even digit from given number
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");             //1234
            int num = Convert.ToInt32(Console.ReadLine());
            int rem;
            while(num!= 0)                                   //1234!=0
            {
                rem = num % 10;                             // 4=1234%10
                if(rem%2==0)                                //if(123.4%2==0)
                {
                    Console.WriteLine(rem);
                }
                num = num / 10;


            }


        }
    }
}

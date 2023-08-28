using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop.While_Loop
{
    internal class Sum_Of_GivenNum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 digit number:");     //789
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (num!=0)         //(789!=0)
            {
                int rem = num % 10;//rem(9)=789%10  
                sum= sum + rem;   //sum()=0+9
                num = num / 10;    //num(78)=789/10
            }
            Console.WriteLine(sum);//(24)
        }
    }
}

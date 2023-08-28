using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    internal class Sum_of_odd_num_1to20
    { //Sum of odd number between 1 to 10
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of odd number between 1 to 10:");
            int sum = 0 ;
            

            for(int i=1; i<=10; i++)
            {
                if(i%2==1)
                {
                    sum = sum + i;
                   
                }

            }
            Console.WriteLine(sum);
        }
    }
}

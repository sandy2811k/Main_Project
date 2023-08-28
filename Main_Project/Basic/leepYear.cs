using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{//Write a program to check whether a year is leap year or not
    internal class leepYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year=Convert.ToInt32(Console.ReadLine());   
           
           


            if ( year % 4 ==0 || year %400==0 && year % 100!=0)
            {
             
               Console.WriteLine("Leap Year");
                
            }
            else
            {
                Console.WriteLine("Not a leap year");
            }
            Console.ReadLine();
            
       
        }
    }
}

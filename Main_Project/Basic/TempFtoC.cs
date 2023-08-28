using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn
{
    internal class TempFtoC
    {//Write a  program to enter temperature in Fahrenheit(°F) and convert it into Celsius(°C)

        static void Main(string[] args)
        {
            Console.WriteLine("Enter temp in fahrenheit(°F): ");
            int f=Convert.ToInt32(Console.ReadLine());
            int res = 0;

            res = (f - 32) * 5 / 7;
            Console.WriteLine("temperature in celsius(°C) :" + res);

        }
    }
}

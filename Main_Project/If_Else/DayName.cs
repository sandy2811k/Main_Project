/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class DayName
    { // to display name as per day number using switch

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number btween 1-7:");

            int daynum = Convert.ToInt32(Console.ReadLine());
            string dayname;
            switch(daynum)
            {
                    case 1:
                    dayname = "sunday";
                    break;

                    case 2:
                    dayname = "monday";
                    break;

                    case 3:
                    dayname = "tuesday";
                    break;

                    case 4:
                    dayname = "wednesday";
                    break;

                    case 5:
                    dayname = "thusday";
                    break;

                    case 6:
                    dayname = "friday";
                    break;

                    case 7:
                    dayname = "saturday";
                    break;

                default:
                    dayname = "invalide ";
                    break;

            }
            Console.WriteLine("the day is "+dayname);

        }
    }
}
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class Light_BiLL
    {
        
 /* Write a C# program to input electricity consumption unit and 
   calculate total electricity bill according to the given condition:
   For first 50 units Rs. 0.50/unit For next 100 units Rs. 0.75/unit 
   For next 100 units Rs. 1.20/unit For unit above 250 Rs. 1.50/unit 
   An additional surcharge of 20% is added to the bill 
   <=50  → 0.50 / unit
   50 -100 → 0.75/ unit
   100-200 → 1.20/unit
   200-250 → 1.50 /unit
   >250 → 1.50 / unit  → amt → additional 20 % surcharge */ 

    internal class bill
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter unit: ");
                double unit = Convert.ToDouble(Console.ReadLine());
                double bill = 0;
                double tbill = 0;

                if (unit <= 50)
                {
                    bill = (unit * 0.50);
                    Console.WriteLine($"Total bill is:" + bill);
                }
                else if (unit > 50 && unit < 100)
                {
                    tbill = (50 * 0.50) + (50 * 0.75) * 0.75;
                    Console.WriteLine($"Total Bill :" + tbill);
                }
                else if (unit > 100 && unit < 200)
                {
                    tbill = ((50 * 0.50) + (50 * 0.75) + (100 * 1.20) + (unit - 200) * 1.20);
                    Console.WriteLine($"Total Bill :" + tbill);

                }
                else if (unit > 200 && unit < 250)
                {
                    tbill = ((50 * 0.50) + (50 * 0.75) + (100 * 1.20) + (50 * 1.50) + (unit - 250) * 1.50);
                    Console.WriteLine($"Total Bill :" + tbill);


                }
                else
                {
                    
                }


            }
        }
    }


}

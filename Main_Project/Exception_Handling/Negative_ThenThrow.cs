using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Exception_Handling
{
    internal class Negative_ThenThrow
    { //If number is negative then throw negative number exception.
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter any number:");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num<0)
                {
                    throw new Exception("Negative number");
                }
                Console.WriteLine("Number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

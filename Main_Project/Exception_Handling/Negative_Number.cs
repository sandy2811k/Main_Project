using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Exception_Handling
{
    internal class Negative_Number
    {
        public static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter Number");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 0)
                {
                    throw new Exception("nagative number");

                }
                Console.WriteLine(num);


            }
            catch (Exception no)
            {

                Console.WriteLine(no.Message);


            }

        }
    }
}
    


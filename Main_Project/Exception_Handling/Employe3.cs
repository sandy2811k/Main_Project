using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Exception_Handling
{
    public class Employe3
    {
        static void Main(string[] args)
        {
            try
            {
                string str = null;
                if (string.IsNullOrEmpty(str))
                {
                    throw new Exception("name is required");
                }
                Console.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Inside the finally block");
            }

        }
    }
}

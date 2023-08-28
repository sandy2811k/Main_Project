using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace Array1
{
    internal class Average
    {
        /* Write two methods that return the average of an array with following headers.
           i.  public static int average(int[] array)
           ii.  public static double average(double[] array).
           iii.Write main and invoke the 2 methods.*/


        public static int average(int[] array)
        {
            int sum = 0, count = 0, avg;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
                count++;
            }
            avg= sum / count;
            return avg;

        }

        public static double average(double[] array) 
        {
            double sum = 0, avg;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter number:");
                array[i]= Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum = (Double)sum + array[i];
                count++;
            }
            avg= (Double)sum / count;
            return avg;


        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine(average(array));
            double[] array1 = new double[3];
            Console.WriteLine(average(array1));
        }
    }
}

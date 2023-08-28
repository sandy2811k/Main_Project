using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Array_
{
    public class Exam_2
    {
        public static char MinChar(char[] array)
        {
            char min = array[0];
            for(int i=0;i<array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                } 
            }
            return min;
        }

        public static char MaxChar(char[] array)
        {
            char max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max= array[i];
                }
            }
            return max;
        }

        public static int [] ReplaceArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]%5==0)
                {
                    array[i] = 0;
                }
            }
            return array;
        }

        public static string AvgOfEven(int[] array)
        { 
            int avg = 0;
            int sum = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    sum = sum + array[i];
                    count++;                       
                }               
            }
            avg = sum / count;
            return $"Average of even element {avg}";

        }
        public static void Main(string[] args)
        {
            char[] array = new char[] { 'a', 'b', 'c', 'f', 'd' }; //Min char
            Console.WriteLine(MinChar(array));

            char[] array1 = new char[] { 'a', 'b', 'c', 'f', 'd' }; //Max char
            Console.WriteLine(MaxChar(array1));

            int[] array3 = new int[] { 10, 22, 40, 77, 60 };  //replace array
            ReplaceArray(array3);

            for(int i=0;i<array3.Length ; i++)
            {
                Console.WriteLine(array3[i]);
            }

            int[] array4 = new int[] { 3,7,8,9 }; //Average of even
            Console.WriteLine(AvgOfEven(array4));
        }
    }
}

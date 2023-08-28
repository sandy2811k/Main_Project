using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.Generic
{
    internal class List_CityName_Find_Frequency
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("Pune", "Word file");
            dictionary.Add("Ahemdnagar", "Excel file");
            dictionary.Add("Aurangab", "C# file");

            foreach (KeyValuePair<string, string> item in dictionary)
            {
                Console.WriteLine($"{item.Key} {item.Value} ");
            }

            Console.WriteLine();
        }
    }
}

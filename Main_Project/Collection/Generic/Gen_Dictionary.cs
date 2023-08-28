using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection
{
    internal class Gen_Dictionary
    {
        static void Main(string[] args)
        {

           Dictionary<string,string> dictionary = new Dictionary<string,string>();

            dictionary.Add(".docx", "Word file");
            dictionary.Add(".xlsx", "Excel file");
            dictionary.Add(".cs", "C# file");

            foreach(KeyValuePair<string,string> item in dictionary) 
            {
                Console.WriteLine($"{ item.Key} { item.Value} ");
            }
          
            Console.WriteLine();

            Dictionary<string, string> dictionary2 = new Dictionary<string, string>();

            dictionary2.Add("+91", "India");
            dictionary2.Add("+975", "Bhutan");
            dictionary2.Add("+55", "Brazil");

            foreach (KeyValuePair<string, string> item2 in dictionary2)
            {
                
                Console.WriteLine($"{item2.Key} {item2.Value} ");
            }


        }
    }
}

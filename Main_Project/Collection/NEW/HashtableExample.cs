using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.NEW
{
    internal class HashtableExample
    {
        static void Main(string[] args)
        {

            Hashtable ht= new Hashtable();
            ht.Add("+91", "India");
            ht.Add("+61", "Australia");
            ht.Add("+55", "Brazil");
            ht.Add("+1", "Canada");

            ht.Remove("+1");//Based on key dada will be removed from hashtable

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key}->{item.Key}");
            }
            Console.ReadLine();
        }
    }
}

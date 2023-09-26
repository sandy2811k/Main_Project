using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.IComparable_Interface
{
    public class Product : IComparable
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
        public int CompareTo(object obj)
        {

            Product p = (Product)obj;
            if (this.price> p.price)
            {
                return 1;
            }
            else if (this.price < p.price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{name}-> {price}";
        }
    }
    public class Program2
    {
        static void Main(string[] args)
        {
            Product Apple = new Product("iphone", 60000);
            Product Samsung = new Product("Flip3", 70000);

            int result = Apple.CompareTo(Samsung);
            if(result == 1)
            {
                Console.WriteLine("Apple Phone more costly than samsung");
            }
            else if(result == -1)
            {
                Console.WriteLine("Samsung Phone more costly than Apple");
            }
            else 
            { 
                Console.WriteLine("Apple & Samsung Phones are same price");
            }
           

        }
    }
}

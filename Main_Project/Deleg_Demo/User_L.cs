using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project
{
    public delegate string Mydelegate(string Name);
    public class user1
    {
        public string AcceptName(string Name)
        {
            return Name;
        }
        public string UpperCase(string Name)
        {
            return Name.ToUpper();
        }
        public string LowerCase(string Name)
        {
            return Name.ToLower();
        }

    }
    public class User_L
    {
        static void Main(string[] args)
        {
            user1 ul = new user1();
            Mydelegate md = new Mydelegate(ul.AcceptName);
            md += new Mydelegate(ul.UpperCase);
            md += new Mydelegate(ul.LowerCase);

            Delegate[] list = md.GetInvocationList();
            foreach (Delegate d in list)
            {
                Console.WriteLine(d.Method);
                string result = Convert.ToString(d.DynamicInvoke("Sandesh Kshirsagar"));
                Console.WriteLine(result);


            }

        }
    }
    
}

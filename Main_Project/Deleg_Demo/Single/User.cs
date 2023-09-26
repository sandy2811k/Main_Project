using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static Main_Project.Deleg_Demo.Single.User;

namespace Main_Project.Deleg_Demo.Single
{
    // Create a class User, create a method with name AccpetName(string name), convert the name in upper case & return.
    // Create the delegate to hold AcceptName method reference & invoke using delegate


    public delegate string MyDelegate(string Name); //delegate always in namespace
    public class User
    {


        public string AcceptName(string Name)
        {
            return Name.ToUpper();
        }


    }

    public class User_UpperCase
    {
        static void Main(string[] args)
        {
            User user = new User();
            MyDelegate md = new MyDelegate(user.AcceptName);//assign the method refrence

            //invoke the method using delegate
            string result = md.Invoke("Sandesh Kshirsagar");
            Console.WriteLine(result);
        }
    }
}

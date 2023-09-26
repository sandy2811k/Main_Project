using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Anonymous_Method
{
    public delegate void MyDelegate();
    public class Event_Method
        {
            public class Student
            {
                public event MyDelegate Fail;
                public event MyDelegate Pass;

                public void AcceptPercentage(double per)
                {
                    if (per < 40)
                    {
                        Fail();
                    }
                    else
                    {
                        Pass();
                    }
                }
            }
            static void Main(string[] args)

            {
                try
                {
                    Student stu = new Student();
                    // bind event with delegate
                    // this a method body / code
                    //{ Console.WriteLine("You are fail"); }
                    stu.Fail += delegate () { Console.WriteLine("You are Fail in Exam"); };
                    stu.Pass += delegate () { Console.WriteLine("You are Pass in Exam"); };

                    stu.AcceptPercentage(5);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Deleg_Demo
{
    public delegate void MyDelegate();
    public class Student
    {
        public event MyDelegate Fail;
        public event MyDelegate Pass;

        public void AcceptPercentage(double per)
        {
            if(per<40)
            {
                Fail();               
            }
            else
            {
                Pass();
            }
        }
    }
    public class message
    {
        public void PassMessage()
        {
            Console.WriteLine("You are Passed in Exam");
        }
        public void FailMessage()
        {
            Console.WriteLine("You are Failed in Exam");
        }

    }
    public class Event_M
    {
        static void Main(string[] args)

        {
            try
            {
                Student stu = new Student();
                message msg = new message();

                stu.Fail += new MyDelegate(msg.FailMessage);
                stu.Pass += new MyDelegate(msg.PassMessage);

                stu.AcceptPercentage(50);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

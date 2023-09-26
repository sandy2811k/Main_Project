using Main_Project.Exception_Handling;
using pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Exception_Handling
{
    public class NameException : Exception
    {
        public NameException(string error) : base(error)
        {
        }
    }
    public class student
    {
        public student(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new NameException("Name is Not enterd");
            }
        }
    }

    public class Student_CLass
    {
        static void Main(string[] args)
        {
            try
            {
                student stu1 = new student(null);
            }
            catch (NameException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

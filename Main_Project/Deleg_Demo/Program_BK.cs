using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Deleg_Demo
{
    public class Program_BK
    {
        static void Main(string[] args)

        {
            try
            {
                bank b = new bank(4000);
                b.Insufficient_Balance += delegate () { Console.WriteLine("Balance is insufficient"); };
                b.Low_Balance += delegate () { Console.WriteLine("Low Balance"); };
                b.Zero_Balance += delegate () { Console.WriteLine("Zero Balance"); };

                b.Credit_method(10000);
                b.Deb_method(14000);
                b.Check_Bal();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }
    }

    public delegate void Mydelegate1();
    public class bank
    {
        public event Mydelegate1 Insufficient_Balance;
        public event Mydelegate1 Low_Balance;
        public event Mydelegate1 Zero_Balance;

        int Bal;
        public bank(int bal)
        {
            this.Bal = bal;
        }

        public int Credit_method(int cred_amt)
        {
            Bal = Bal + cred_amt;
            return Bal;
        }

        public int Deb_method(int Deb_amt)
        {
            if(Bal<Deb_amt)
            {
                Insufficient_Balance();
            }
            else
            {
                Bal = Bal - Deb_amt;

            }
            return Bal;
        }

        public void Check_Bal()
        {
            if(Bal==0)
            {
                Zero_Balance();
            }
            else
            {
                Low_Balance();
            }
        }
    }



}

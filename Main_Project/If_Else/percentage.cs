using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment4
{
    internal class percentage
    { /*Accept marks of 3 subjects physics ,chemistry , maths out of 100. Calculate percentage.
        Display grade as below.
        Percentage > 80% - Grade A
        Percentage > 70% - Grade B
        Percentage > 60% - Grade C
        Percentage< 60% - Grade D */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks of given subjects:(out of 100)");
            Console.Write("Physics :");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("chemistry :");
            int chem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Math :");
            int math = Convert.ToInt32(Console.ReadLine());
            int tot=0;
            float per;

            tot = (phy + chem + math);
            per =((float)tot/300)*100;
            Console.WriteLine($"Total marks :{tot}(out of 300)" );
            Console.WriteLine($"Persentage:{per} %");

            if (phy < 35 || chem < 35 || math < 35)
            {
                Console.WriteLine("fail");

            }
            else 
                {

                if (per > 80)
                {
                    Console.WriteLine("Grade A");
                }
                else if (per > 70)
                {
                    Console.WriteLine("Grade B");
                }
                else if (per > 60)
                {
                    Console.WriteLine("Grade C");
                }
                else if (per < 60 || per >= 35)
                {
                    Console.WriteLine("Grade D");
                }
                else
                {
                    Console.WriteLine("Fail");
                }
            }




        }
    }
}

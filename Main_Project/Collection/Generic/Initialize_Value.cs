﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Project.Collection.Generic
{
    internal class Initialize_Value
    { //WAP to create an array of 5 integers. Initialize 5 values. Display using foreach loop.

        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);  
            list.Add(4);
            list.Add(5);

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }



        }
    }
}

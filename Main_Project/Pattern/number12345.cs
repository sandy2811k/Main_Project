﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern
{
    internal class number12345
    {
        static void Main(string[] args)
        {
            for(int i=5; i>=1; i--) 
            {
                for(int  j=1; j<=i; j++)
                {
                    Console.Write(j);

                }Console.WriteLine();
            }
        }
    }
}

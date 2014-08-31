﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLine
{
    class Program
    {
        public static void Main(string[] args)
        {
            // The Length property is used to obtain the length of the array. 
            // Notice that Length is a read-only property:
            Console.WriteLine("Number of command line parameters = {0}",
               args.Length);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg[{0}] = [{1}]", i, args[i]);
            }
        }
    }
}

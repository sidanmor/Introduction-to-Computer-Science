﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisAndBase
{
    public class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }
}

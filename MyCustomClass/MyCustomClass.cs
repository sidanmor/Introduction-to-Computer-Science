using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomClass
{
    class MyCustomClass
    {
        // Class members: 
        // Property. 
        public int Number { get; set; }

        // Method. 
        public int Multiply(int num)
        {
            return num * Number;
        }

        // Instance Constructor. 
        public MyCustomClass()
        {
            Number = 0;
        }
    }
}

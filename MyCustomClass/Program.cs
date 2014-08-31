using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type MyCustomClass.
            MyCustomClass myClass = new MyCustomClass();

            // Set the value of a public property.
            myClass.Number = 27;

            // Call a public method. 
            int result = myClass.Multiply(4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisAndBase
{
    class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method: 
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }
}

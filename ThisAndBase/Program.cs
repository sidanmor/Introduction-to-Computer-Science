using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisAndBase
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee E = new Employee();
            E.GetInfo();

            //------------------------------------

            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(1);
        }
    }
}

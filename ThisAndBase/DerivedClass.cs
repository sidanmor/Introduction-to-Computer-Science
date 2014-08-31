using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisAndBase
{
    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass() 
        public DerivedClass()
            : base()
        {
        }

        // This constructor will call BaseClass.BaseClass(int i) 
        public DerivedClass(int i)
            : base(i)
        {
        }

    }
}

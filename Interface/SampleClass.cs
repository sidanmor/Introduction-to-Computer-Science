using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    class SampleClass : IControl, ISurface
    {
        // Both ISurface.Paint and IControl.Paint call this method.  
        public void Paint()
        {
            Console.WriteLine("Paint method in SampleClass");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Lion : Animal
    {
        public Lion()
        {
            Console.WriteLine("Lion constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Lion talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Lion song");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Monkey : Animal
    {
        public Monkey()
        {
            Console.WriteLine("Monkey constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Monkey talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Monkey song");
        }
    }
}

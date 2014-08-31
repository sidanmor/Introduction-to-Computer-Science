using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Cat constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Cat talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Cat song");
        }
    }
}

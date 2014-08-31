using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Talk();
            a1.Sing();
            a1.Greet();

            Console.WriteLine("----------------------------------------");

            Animal a2 = new Dog();
            a2.Talk();
            a2.Sing();
            a2.Greet();

            Console.WriteLine("----------------------------------------");

            Dog d1 = new Dog();
            d1.Talk();
            d1.Sing();
            d1.Greet();

            Console.WriteLine("----------------------------------------");

            Animal[] animals = new Animal[5];
            animals[0] = new Animal();
            animals[1] = new Dog();
            animals[2] = new Cat();
            animals[3] = new Lion();
            animals[4] = new Monkey();

            Console.WriteLine("----------------------------------------");

            foreach (var animal in animals)
            {
                animal.Sing();                
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

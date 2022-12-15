using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// [Polymorphism]
            /// It is consisdered polymorphism because Animal is the parent of cat, dog, duck
            /// </summary>
            Animal cat = new Cat("meow");
            Animal dog = new Dog("arf");
            Animal duck = new Duck("quack");
            System.Console.WriteLine(cat.sound());
        }
    }
}

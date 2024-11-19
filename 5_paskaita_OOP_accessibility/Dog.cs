using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Dog : Animal
    {
        public Dog(string name, string sound) : base(name, sound)
        {
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(Sound);
        }
    }
}

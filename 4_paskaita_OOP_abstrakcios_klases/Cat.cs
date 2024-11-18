using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    internal class Cat : Animal
    {
        public Cat(double weight) : base(weight)
        {
            
        }
        public override string Sound => "Meow Meow!";

        public override void MakeNoise()
        {
            Console.WriteLine("Cat says: " + Sound);
        }
    }
}

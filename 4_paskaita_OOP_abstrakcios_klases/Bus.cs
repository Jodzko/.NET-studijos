using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public class Bus : Vehicle
    {
        
        public int RequiredAgeToDrive { get; set; }
        public Bus(string name, int wheelCount, string maker, char categoryRequiredToDrive, int requiredAge) : base(name, wheelCount, maker, categoryRequiredToDrive)
        {
            RequiredAgeToDrive = requiredAge;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Vehicle name: {Name}");
            Console.WriteLine("Wheel count: " + WheelCount);
            Console.WriteLine("Maker: " + Maker);
            Console.WriteLine("Category required to drive: " + CategoryRequiredToDrive);
            Console.WriteLine("Age required to drive: " + RequiredAgeToDrive);
            
        }
    }
}

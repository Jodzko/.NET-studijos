using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public class Bike : Vehicle
    {
        public bool HaveToBeCool { get; set; }
        public Bike(string name, int wheelCount, string maker, char categoryRequiredToDrive, bool haveToBeCool) : base(name, wheelCount, maker, categoryRequiredToDrive)
        {
            HaveToBeCool = haveToBeCool;
        }

        public override void ShowInformation()
        {
            Console.WriteLine($"Vehicle name: {Name}");
            Console.WriteLine("Wheel count: " + WheelCount);
            Console.WriteLine("Maker: " + Maker);
            Console.WriteLine("Category required to drive: " + CategoryRequiredToDrive);
            Console.WriteLine("You have to be cool to drive: " + HaveToBeCool);

        }
    }
}

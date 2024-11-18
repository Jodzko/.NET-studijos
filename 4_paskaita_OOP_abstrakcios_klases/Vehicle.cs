using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int WheelCount { get; set; }
        public string Maker { get; set; }
        public char CategoryRequiredToDrive { get; set; }

        public Vehicle(string name, int wheelCount, string maker, char categoryRequiredToDrive)
        {
            Name = name;
            WheelCount = wheelCount;
            Maker = maker;
            CategoryRequiredToDrive = categoryRequiredToDrive;
        }


        public abstract void ShowInformation();
    }
}

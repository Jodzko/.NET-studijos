using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public class LesserHuman : Human
    {
        public LesserHuman(string name) : base(name)
        {
        }

        

        public override void ShowVehicles()
        {
            Console.WriteLine($"Driver name: {Name} ");
            foreach (var vehicle in ListOfVehicles)
            {
                vehicle.ShowInformation();
            }
        }
    }
}

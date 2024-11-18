using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    public abstract class Human
    {
        public string Name { get; set; }
        public List<Vehicle> ListOfVehicles { get; set; }
        public Human(string name)
        {
            Name = name;
            ListOfVehicles = new List<Vehicle>();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Add(vehicle);
        }


        public abstract void ShowVehicles();
        
        
    }
}

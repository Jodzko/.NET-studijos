using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.Models
{
    internal class Pet
    {
        public string Name { get; set; }
        public string AnimalType { get; set; }
        public int Age  { get; set; }

        public Pet(string name, string animalType, int age)
        {
            Name = name;
            AnimalType = animalType;
            Age = age;
        }
    }
}

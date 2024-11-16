using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai.Models
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }





        public List<Pet> Pets { get; set; } = new List<Pet>();

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public Human(List<Pet> pets)
        {
            Pets = pets;
        }

        public string GetFullName()
        {
            return ($"{FirstName} {LastName}");
        }
        public void PrintPets()
        {
            foreach (var pet in Pets)
            {
                Console.WriteLine($"{pet.AnimalType}, {pet.Name}, {pet.Age}");
            }
        }

    }

    
}




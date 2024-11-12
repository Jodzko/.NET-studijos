using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektinis_Programavimas
{
    internal class Person1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        public Person1(string name, int age, Address address)
        {
            Name = name;
            Age = age;
            Address = address;
            
            
        }
    }
}

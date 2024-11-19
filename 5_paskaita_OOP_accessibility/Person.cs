using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    public class Person
    {

        protected string Name { get;private set; }
        protected int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected void PrintInfo()
        {
            Console.WriteLine($"{Name} {Age}");
        }
    }
}

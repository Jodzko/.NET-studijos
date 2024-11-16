using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Employee1
    {
        public string Name { get; set; }

        public Employee1()
        {

        }
        public Employee1(string name)
        {
            Name = name;
        }

        public virtual void Greeting()
        {
            Console.WriteLine("Hello " + Name);
        }
    }
}

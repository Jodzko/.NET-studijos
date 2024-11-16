using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Programmer : Employee
    {
        

        public string ProgrammingLanguage { get; set; }

        public Programmer(string language, string name, int salary) : base(name, salary)
        {
            
            ProgrammingLanguage = language;
        }


    }
}

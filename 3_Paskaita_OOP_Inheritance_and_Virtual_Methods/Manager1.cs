using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Paskaita_OOP_Inheritance_and_Virtual_Methods
{
    public class Manager1 : Employee1
    {

        public Manager1()
        {

        }
        public Manager1(string name)
        {
            Name = name;
        }


        public override void Greeting()
        {
            base.Greeting();
        }
    }
}

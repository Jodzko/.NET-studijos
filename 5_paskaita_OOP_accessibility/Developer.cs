using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary)
        {
        }

        public sealed override double GetSalary()
        {
            double developerSalary = Salary * 2;
            Salary = developerSalary;
            Console.WriteLine(Salary);
            return Salary;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary)
        {
        }

        public sealed override double GetSalary()
        {
            double managerSalary = Salary * 1.5;
            Salary = managerSalary;
            Console.WriteLine(Salary);
            return Salary * 1.5;
        }
    }

}

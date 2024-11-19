using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Teacher : Person
    {
        private string Subject { get; set; }
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            Subject = subject;
        }

        public string GetSubject()
        {
            return Subject;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    public class Student : Person
    {
        private int StudentID { get; set; }
        public Student(string name, int age, int studentID) : base(name, age)
        {
            StudentID = studentID;
        }

        public int GetStudentID()
        {            
            return StudentID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Objektinis_Programavimas
{
    internal class School
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int StudentCount { get; set; }

        public School(string name, string city, int studentCount)
        {
            Name = name;
            City = city;
            StudentCount = studentCount;
        }
    }



    
}

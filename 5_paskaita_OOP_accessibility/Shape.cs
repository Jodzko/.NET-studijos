using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Shape()
        {
        }

        public Shape(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public virtual double CalculateArea()
        {
            double area = Side1 * Side2;
            Console.WriteLine(area);
            return area;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai
{
    internal class Circle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }
        public double CalculateCircumference()
        {
            double circumference = 2 * Math.PI * Radius;
            return circumference;
        }
    }
}

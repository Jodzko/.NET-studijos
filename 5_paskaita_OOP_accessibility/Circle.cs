using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_paskaita_OOP_accessibility
{
    internal class Circle : Shape
    {
        public Circle(int radius)
        {
            Side1 = radius;
        }

        public sealed override double CalculateArea()
        {
            double area = Math.PI * (Side1 * Side1);
            Console.WriteLine(area);
            return area;
        }
    }
}

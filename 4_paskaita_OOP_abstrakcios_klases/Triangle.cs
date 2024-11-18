using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    internal class Triangle : GeometricShape
    {
        public int Side2 { get; set; }
        public int Base { get; set; }
        public int Height { get; set; }

        public Triangle(int side1, int height, int side2, int side3) : base(side1)
        {
            Height = height;
            Side2 = side2;
            Base = side3;
        }
        public override void GetArea()
        {
            double area = (Height * Base) / 2;
            Console.WriteLine("The area of the triangle is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = Side1 + Side2 + Base;
            Console.WriteLine("The perimeter of the triangle is: " + perimeter);
        }
    }
}

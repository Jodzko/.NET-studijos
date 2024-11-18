using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    internal class Square : GeometricShape
    {
        public Square(int side1) : base(side1)
        {
            
        }
        public override void GetArea()
        {
            double area = Side1 * Side1;
            Console.WriteLine("The area of the square is: " + area);
        }

        public override void GetPerimeter()
        {
            double perimeter = Side1 * 4;
            Console.WriteLine("The perimeter of the square is: " + perimeter);
        }
    }
}

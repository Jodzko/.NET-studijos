using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_paskaita_OOP_klasiu_metodai
{
    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            Height = height;
            Width = width;
        }


        public void CalculatePerimeter()
        {
            double perimeter = (Height + Width) * 2;
            Console.WriteLine(perimeter);
        }

        public void CalculateArea()
        {
            double area = Height * Width;
            Console.WriteLine(area);
        }
    }
}

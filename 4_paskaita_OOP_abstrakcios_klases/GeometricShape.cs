using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_OOP_abstrakcios_klases
{
    internal abstract class GeometricShape
    {
        public int Side1 { get; set; }
        
        public GeometricShape(int side1)
        {
            Side1 = side1;
            
        }

        public abstract void GetArea();

        public abstract void GetPerimeter();

    }
}

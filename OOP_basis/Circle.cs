using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Circle : GeometricFigure
    {
        private int radius;

        public Circle(int r) : base("Круг")
        {
            radius = r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}

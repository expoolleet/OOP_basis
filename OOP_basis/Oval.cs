using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Oval : GeometricFigure
    {
        private int radius_1;
        private int radius_2;

        public Oval(int r1, int r2) : base("Овал")
        {
            radius_1 = r1;
            radius_2 = r2;
        }

        public override double Perimeter()
        {
            return 4 * (Math.PI * radius_1 * radius_2 + (radius_1 - radius_2)) / (radius_1 + radius_2);
        }
        public override double Square()
        {
            return radius_1 * radius_2 * Math.PI;
        }
    }
}

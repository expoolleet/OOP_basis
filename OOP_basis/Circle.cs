using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Circle : GeometricFigure
    {
        private double radius;

        public Circle(double r) : base("Круг")
        {
            radius = r;
        }

        public override double Perimeter()
        {
            return Math.Round(2 * Math.PI * radius);
        }

        public override double Space()
        {
            return Math.Round(Math.PI * Math.Pow(radius, 2));
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {name} с радиусом {radius} имеет периметр равный {Perimeter()}, площадь равную {Space()}");
        }
    }
}

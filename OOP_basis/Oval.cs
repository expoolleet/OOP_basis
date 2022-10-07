using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Oval : GeometricFigure
    {
        private double radius_1;
        private double radius_2;

        public Oval(double r1, double r2) : base("Овал")
        {
            radius_1 = r1;
            radius_2 = r2;
        }

        public override double Perimeter()
        {
            return Math.Round(4 * (Math.PI * radius_1 * radius_2 + (radius_1 - radius_2)) / (radius_1 + radius_2));
        }
        public override double Space()
        {
            return Math.Round(radius_1 * radius_2 * Math.PI);
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {name} с радиусами: {radius_1} и {radius_2} имеет периметр равный {Perimeter()}, площадь равную {Space()}");
        }
    }
}

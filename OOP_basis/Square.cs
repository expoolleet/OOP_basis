using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    internal class Square : GeometricFigure
    {
        double a;

        public Square(double a) : base("Квадрат")
        {
            this.a = a;
        }

        public override double Perimeter()
        {
            return a * 4;
        }

        public override double Space()
        {
            return a * a;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {name} со сторонами: {a} имеет периметр равный {Perimeter()}, площадь равную {Space()}");
        }

    }
}

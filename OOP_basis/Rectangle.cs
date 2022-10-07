using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    internal class Rectangle : GeometricFigure
    {
        private double a;
        private double b;

        public Rectangle(double a, double b) : base("Прямоугольник")
        {
            this.a = a;
            this.b = b;
        }

        public override double Perimeter()
        {
            return (a + b) * 2;
        }
        public override double Space()
        {
            return a * b;
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {name} со сторонами: {a} и {b} имеет периметр равный {Perimeter()}, площадь равную {Space()}");
        }
    }
}

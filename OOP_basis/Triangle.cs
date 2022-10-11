using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Triangle : GeometricFigure
    {
        private double a;
        private double b;
        private double c;
        public Triangle(double a, double b, double c) : base("Треугольник")
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == b && a == c) name += " равносторонний";
            else if (a == b || b == c || a == c) name += " равнобедренный";
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) name += " прямоугольный";
            else name += " разносторонний";
        }

        public override double Perimeter()
        {
            return a + b + c;
        }
        public override double Square()
        {
            double p = (a + b + c) / 2;

            return Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {name} со сторонами: {a}, {b} и {c} имеет периметр равный {Perimeter()}, площадь равную {Square()}");
        }
    }
}

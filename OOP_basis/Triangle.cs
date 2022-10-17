using System;

namespace OOP_basis
{
    class Triangle : GeometricFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == b && a == c) Name = "Треугольник равносторонний";
            else if (a == b || b == c || a == c) Name = "Треугольник равнобедренный";
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) Name = "Треугольник прямоугольный";
            else Name = "Треугольник разносторонний";

            FigureIndex = 3;
        }

        public override double PerimeterFunc()
        {
            Perimeter = a + b + c;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            double p = (a + b + c) / 2;

            Square = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)));

            return Square;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {Name} со сторонами: {a}, {b} и {c} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
        }
    }
}

using System;

namespace OOP_basis
{
    class Triangle : GeometricFigure
    {
        //private double sideA;
        //private double sideB;
        //private double sideC;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            if (a == b && a == c) Name = "Треугольник равносторонний";
            else if (a == b || b == c || a == c) Name = "Треугольник равнобедренный";
            else if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) Name = "Треугольник прямоугольный";
            else Name = "Треугольник разносторонний";

            FigureIndex = 3;
        }

        public override double PerimeterFunc()
        {
            Perimeter = A + B + C;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            double p = (A + B + C) / 2;

            Square = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)));

            return Square;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Фигура {Name} со сторонами: {A}, {B} и {C} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
        }
    }
}

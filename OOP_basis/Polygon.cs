using System;

namespace OOP_basis
{
    internal class Polygon : GeometricFigure
    {
        private double a;
        private double b;

        public Polygon(double a, double b)
        {
            if (a == b)
            {
                Name = "Квадрат";
            }
            else
            {
                Name = "Прямоугольник";
            }
            this.a = a;
            this.b = b;

            FigureIndex = 2;
        }       

        public override double PerimeterFunc()
        {
            Perimeter = (a + b) * 2;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = a * b;
            return Square;
        }
        public override void GetInfo()
        {
            if (a == b)
            {
                Console.WriteLine($"Фигура {Name} со стороной: {a} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }
            else
            {
                Console.WriteLine($"Фигура {Name} со сторонами: {a} и {b} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }   
        }
    }
}

using System;

namespace OOP_basis
{
    internal class Polygon : GeometricFigure
    {
        //private double sideA;
        //private double sideB;

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
            A = a;
            B = b;

            FigureIndex = 2;
        }       

        public override double PerimeterFunc()
        {
            Perimeter = (A + B) * 2;
            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = A * B;
            return Square;
        }
        public override void GetInfo()
        {
            if (A == B)
            {
                Console.WriteLine($"Фигура {Name} со стороной: {A} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }
            else
            {
                Console.WriteLine($"Фигура {Name} со сторонами: {A} и {B} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }   
        }
    }
}

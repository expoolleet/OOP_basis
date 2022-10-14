using System;

namespace OOP_basis
{
    internal class Polygon : GeometricFigure
    {
        private double a;
        private double b;

        public Polygon(double a, double b) : base("")
        {
            if (a == b)
            {
                name = "Квадрат";
            }
            else
            {
                name = "Прямоугольник";
            }
            this.a = a;
            this.b = b;
        }       

        public override double Perimeter()
        {
            return (a + b) * 2;
        }
        public override double Square()
        {
            return a * b;
        }
        public override void GetInfo()
        {
            if (a == b)
            {
                Console.WriteLine($"Фигура {name} со стороной: {a} имеет периметр равный {Perimeter()}, площадь равную {Square()}");
            }
            else
            {
                Console.WriteLine($"Фигура {name} со сторонами: {a} и {b} имеет периметр равный {Perimeter()}, площадь равную {Square()}");
            }
           
        }
    }
}

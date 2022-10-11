using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    internal class Polygon : GeometricFigure
    {
        private double a;
        private double b;

        public Polygon(double a) : base("Квадрат")
        {
            this.a = a;
                 b = a;
        }
        public Polygon(double a, double b) : base("Прямоугольник")
        {
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

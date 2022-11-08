using System;


namespace OOP_basis
{
    class Ellipse : GeometricFigure
    {
        //private double sideA;
        //private double sideB;

        
        public Ellipse(double r1, double r2)
        {
            if (r1 == r2)
            {
                Name = "Круг";
            }
            else
            {
                Name = "Овал";
            }
            A = r1;
            B = r2;

            FigureIndex = 1;
        }

        public override double PerimeterFunc()
        {
            Perimeter = Math.Round(4 * (Math.PI * A * B + Math.Pow((A - B), 2)) / (A + B));

            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = Math.Round(A * B * Math.PI);

            return Square;
        }
        public override void GetInfo()
        {
            if (A == B)
            {
                Console.WriteLine($"Фигура {Name} с радиусам: {A} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }
            else
            {
                Console.WriteLine($"Фигура {Name} с радиусами: {A} и {B} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }           
        }

    }
}

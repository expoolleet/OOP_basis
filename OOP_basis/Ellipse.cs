using System;


namespace OOP_basis
{
    class Ellipse : GeometricFigure
    {
        private double radius_1;
        private double radius_2;

        
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
            radius_1 = r1;
            radius_2 = r2;

            FigureIndex = 1;
        }

        public override double PerimeterFunc()
        {
            Perimeter = Math.Round(4 * (Math.PI * radius_1 * radius_2 + Math.Pow((radius_1 - radius_2), 2)) / (radius_1 + radius_2));

            return Perimeter;
        }
        public override double SquareFunc()
        {
            Square = Math.Round(radius_1 * radius_2 * Math.PI);

            return Square;
        }
        public override void GetInfo()
        {
            if (radius_1 == radius_2)
            {
                Console.WriteLine($"Фигура {Name} с радиусам: {radius_1} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }
            else
            {
                Console.WriteLine($"Фигура {Name} с радиусами: {radius_1} и {radius_2} имеет периметр равный {PerimeterFunc()}, площадь равную {SquareFunc()}");
            }           
        }

    }
}

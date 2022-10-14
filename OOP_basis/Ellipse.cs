using System;


namespace OOP_basis
{
    class Ellipse : GeometricFigure
    {
        private double radius_1;
        private double radius_2;

        public Ellipse(double r1, double r2) : base("")
        {
            if (r1 == r2)
            {
                name = "Круг";
            }
            else
            {
                name = "Овал";
            }
            radius_1 = r1;
            radius_2 = r2;
        }

        public override double Perimeter()
        {
            return Math.Round(4 * (Math.PI * radius_1 * radius_2 + Math.Pow((radius_1 - radius_2), 2)) / (radius_1 + radius_2));
        }
        public override double Square()
        {
            return Math.Round(radius_1 * radius_2 * Math.PI);
        }
        public override void GetInfo()
        {
            if (radius_1 == radius_2)
            {
                Console.WriteLine($"Фигура {name} с радиусам: {radius_1} имеет периметр равный {Perimeter()}, площадь равную {Square()}");
            }
            else
            {
                Console.WriteLine($"Фигура {name} с радиусами: {radius_1} и {radius_2} имеет периметр равный {Perimeter()}, площадь равную {Square()}");
            }           
        }
    }
}

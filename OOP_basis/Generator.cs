using System;

namespace OOP_basis
{
    class Generator
    {
        private int figureIndex;
        private double r1;
        private double r2;
        private double a;
        private double b;
        private double c;
        GeometricFigure figure;

        private Random random;
        public Generator(int f, Random random)
        {
            figureIndex = f;
            this.random = random;
        }

        public GeometricFigure Generate()
        {
            switch (figureIndex)
            {
                case 1:
                    r1 = random.Next(1, 6);
                    r2 = random.Next(1, 6);

                    figure = new Ellipse(r1, r2);

                    break;
                case 2:
                    a = random.Next (1, 10);
                    b = random.Next(1, 10);

                    figure = new Polygon(a, b);

                    break;
                case 3:
                    do
                    {
                        a = random.Next(1, 10);
                        b = random.Next(1, 10);
                        c = random.Next(1, 10);

                    } while ((a + b) <= c || (a + c) <= b || (b + c) <= a);

                    figure = new Triangle(a, b, c);

                    break;
            }

            return figure;
        }
    }
}

using System;

namespace OOP_basis
{
    class Generator
    {
        private int figureIndex;

        GeometricFigure figure;

        private Random random;
        public Generator(int f, Random random)
        {
            figureIndex = f;
            this.random = random;
        }

        public GeometricFigure Generate()
        {
            double r1;
            double r2;
            double a;
            double b;
            double c;

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

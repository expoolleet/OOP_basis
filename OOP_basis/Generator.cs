using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Generator
    {
        private int figureIndex;


        private Random random;
        public Generator(int f, Random random)
        {
            figureIndex = f;
            this.random = random;
        }

        public void Generate()
        {
            GeometricFigure figure;
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

                    figure.GetInfo();
                    break;

                case 2:
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);

                    figure = new Polygon(a, b);

                    figure.GetInfo();
                    break;

                case 3: 
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);
                    c = random.Next(1, 10);

                    if ((a + b) > c && (a + c) > b && (b + c) > a)
                    {
                        figure = new Triangle(a,b,c);  
                    }
                    else
                    {
                        Generate();
                        return;
                    }

                    figure.GetInfo();
                    break;      
            }
        }
    }
}

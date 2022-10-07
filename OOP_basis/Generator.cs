using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    class Generator
    {
        int i;

        private int figureIndex;

        GeometricFigure figure;

        private Random random = new Random();
        public Generator(int f)
        {
            figureIndex = f;
        }

        public void Generate()
        {
            double r1;
            double r2;
            double a;
            double b;
            double c;

            switch (figureIndex)
            {
                case 1:
                    r1 = random.Next(1, 5);
                    r2 = random.Next(1, 5);

                    if (r1 == r2)
                    {
                       figure = new Circle(r1); 
                    }
                    else
                    {
                       figure = new Oval(r1, r2);
                    }

                    figure.GetInfo();
                    break;

                case 2:
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);

                    if (a == b)
                    {
                        figure = new Square(a);
                    }
                    else
                    {
                        figure = new Rectangle(a, b);
                    }

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

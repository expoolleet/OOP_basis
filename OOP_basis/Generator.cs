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

        GeometricFigure figure;

        private Random random = new Random();
        public Generator(int f)
        {
            figureIndex = f;
        }

        public void Generate()
        {
            int r1;
            int r2;
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

                    Console.WriteLine($"Фигура {figure.name} имеет периметр равный {figure.Perimeter():N2} и площадь равную {figure.Square():N2}");
                    break;
            }
        }
    }
}

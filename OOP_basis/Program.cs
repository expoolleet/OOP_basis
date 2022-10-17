using System;
using System.Linq;

namespace OOP_basis
{
    class Program
    {
        static void Main()
        {  
            int n = 10;
            Random random = new Random();

            GeometricFigure[] figures = new GeometricFigure[n];


            for (int i = 0; i < n; i++)
            {
                figures[i] = new Generator(random.Next(1, 4), random).Generate();
            }

            Figures figuresList = new Figures(figures);

            foreach(var figure in figuresList)
            {
                figure.GetInfo();
            }


            Console.WriteLine("\n\tВсе фигуры с первой буквой К");
            var selectedFiguresWhere = from f1 in figures
                                  where f1.Name.ToUpper().StartsWith("К")
                                  select f1;
            foreach(var figure in selectedFiguresWhere)
            {
                Console.WriteLine(figure.Name);
            }

            Console.WriteLine("\n\tВсе фигуры составленные по алфавиту");
            var selectedFiguresOrberBy = from f2 in figures
                                         orderby f2.Name
                                         select f2;
            foreach (var figure in selectedFiguresOrberBy)
            {
                Console.WriteLine(figure.Name);
            }

            Console.WriteLine("\n\tГруппы объектов ");
            var selectedFiguresGroupBy = from f3 in figures
                                         group f3 by f3.FigureIndex;
            foreach (var figure in selectedFiguresOrberBy)
            {
                Console.WriteLine(figure.Name);
            }


            Console.WriteLine("\n\tВсе объекты с площадью меньше 4(включительно)");
            var selectedFiguresAllSquareSumLessThan4 = from f4 in figures
                                                       where f4.Square <= 4
                                                       select f4;
            foreach (var figure in selectedFiguresAllSquareSumLessThan4)
            {
                figure.GetInfo();
            }

            Console.WriteLine("\n\tСумма периметров");
            var selectedPerimeterSum = figures.Select(f => f.Perimeter).Sum();
            Console.WriteLine(selectedPerimeterSum);

            Console.WriteLine("\n\tМинимальный периметр");
            var selectedPerimeterMin = figures.Select(f => f.Perimeter).Min();
            Console.WriteLine(selectedPerimeterMin);

            Console.WriteLine("\n\tМаксимальный периметр");
            var selectedPerimeterMax = figures.Select(f => f.Perimeter).Max();
            Console.WriteLine(selectedPerimeterMax);

            Console.Write("Enter для повтора... ");
            string x = Console.ReadLine();
            switch (x)
            {
                case "": Main(); break;
            }
        }
    }
}

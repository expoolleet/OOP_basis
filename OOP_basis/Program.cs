using System;
using System.Collections;
using System.Linq;

namespace OOP_basis
{
    class Program
    {
        static void Main()
        {  
            int n = 10;
            Random random = new Random();
            ArrayList figuresArray = new ArrayList();

            GeometricFigure[] figures = new GeometricFigure[n];


            for (int i = 0; i < n; i++)
            {
                figuresArray.Add(new Generator(random.Next(1, 4), random).Generate());
            }

            figuresArray.Sort(); // Сортировка фигур в списке по их периметрам (IComparable)

            GeometricFigure[] figures = (GeometricFigure[])figuresArray.ToArray(typeof(GeometricFigure)); // Преобразование списка типа Object[] в массив типа GeometricFigure[]

            Figures figuresList = new Figures(figures); // Список из фигур в массиве figures (IEnumerable)

            foreach (GeometricFigure figure in figuresArray) // Просмотр каждого элемента в отсортированном массиве
            {
                figure.GetInfo();
            }

            foreach (GeometricFigure figure in figuresArray)
            {
                foreach (GeometricFigure figure1 in figuresArray)
                {
                    Console.WriteLine(figure.Equals(figure1));
                }
                break;
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
            var sortetFigures = selectedFiguresGroupBy.OrderBy(f => f.Key);

            foreach (var figureKey in sortetFigures)
            {
                Console.WriteLine($"Группа {figureKey.Key}:");
                    foreach(var figure in figureKey)
                    {
                        Console.WriteLine(figure.Name);
                    }
                Console.WriteLine();
            }

            Console.WriteLine("\n\tЛюбая фигура, у которой площадь больше 4");
            var selectedFigureAnySquareMoreThan4 = figures.Where(f => f.Square > 4).FirstOrDefault();
            selectedFigureAnySquareMoreThan4.GetInfo();

            Console.WriteLine("\n\tВсе объекты с площадью не больше 4");
            var selectedFiguresAllSquareSumLessThan4 = from f5 in figures
                                                       where f5.Square <= 4
                                                       select f5;
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

            Console.Write("Enter для повтора...");
            string x = Console.ReadLine();
            switch (x)
            {
                case "": Main(); break;
                default: Main(); break;
            }
        }
    }
}

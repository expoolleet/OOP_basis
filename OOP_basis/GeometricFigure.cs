using System;

namespace OOP_basis
{
    public abstract class GeometricFigure : IComparable
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public double C { get; protected set; }
        public int FigureIndex { get; protected set; }

        public string Name { get; protected set; }

        public double Square { get; protected set; }

        public double Perimeter { get; protected set; }

       // public GeometricFigure() { }

        public abstract double SquareFunc();

        public abstract double PerimeterFunc();

        public abstract void GetInfo();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            GeometricFigure figure = obj as GeometricFigure;
            if (figure != null)
                return PerimeterFunc().CompareTo(figure.PerimeterFunc());
            else
                throw new ArgumentException("Object is not a Figure");
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;

            if (!(obj is GeometricFigure)) return false;

            var figure = obj as GeometricFigure;

            return figure.FigureIndex == FigureIndex && figure.Square == Square && figure.Perimeter == Perimeter;
        }
    }
}

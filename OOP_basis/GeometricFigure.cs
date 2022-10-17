using System;

namespace OOP_basis
{
    public abstract class GeometricFigure
    {
        public int FigureIndex { get; protected set; }

        public string Name { get; protected set; }

        public double Square { get; protected set; }

        public double Perimeter { get; protected set; }

        public GeometricFigure() { }

        public abstract double SquareFunc();

        public abstract double PerimeterFunc();

        public abstract void GetInfo();
    }
}

using System;


namespace OOP_basis
{
    abstract class GeometricFigure
    {
        public string name;

        public GeometricFigure(string n)
        {
            name = n;
        }

        public abstract double Square();
        public abstract double Perimeter();
        public abstract void GetInfo();
    }
}

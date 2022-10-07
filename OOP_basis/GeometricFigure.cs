using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basis
{
    abstract class GeometricFigure
    {
        public string name;

        public GeometricFigure(string n)
        {
            name = n;
        }

        public abstract double Space();
        public abstract double Perimeter();
        public abstract void GetInfo();
    }
}

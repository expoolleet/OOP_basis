using System;
using System.Collections;


namespace OOP_basis
{
    public class Figures : IEnumerable
    {
        private GeometricFigure[] figures;

        private int count;

        public int Count
        {
            get
            {
                return count;
            }
            private set
            {
                count = value;
            }
        }


        public Figures(GeometricFigure[] geometricFigures)
        {
            figures = new GeometricFigure[geometricFigures.Length];
            Count = geometricFigures.Length;

            for (int i = 0; i < geometricFigures.Length; i++)
            {
                figures[i] = geometricFigures[i];
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public FigureEnum GetEnumerator()
        {
            return new FigureEnum(figures);
        }
    }

    public class FigureEnum : IEnumerator
    {
        public GeometricFigure[] figures;

        private int position = -1;

        public FigureEnum(GeometricFigure[] list)
        {
            figures = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < figures.Length);
        }

        public void Reset()
        {
            position = -1;
        }


        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public GeometricFigure Current
        {
            get
            {
                try
                {
                    return figures[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}

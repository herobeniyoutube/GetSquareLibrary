using System;
using System.Collections.Immutable;
using System.Linq;

namespace MindboxTask.Figures
{
    public class Circle : AbstractFigure
    {
        internal Circle(IImmutableList<double> sides)
        {
            Radius = sides.First();
        }

        public double Radius { get; }

        public override double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
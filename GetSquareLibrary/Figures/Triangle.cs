using System;
using System.Collections.Immutable;
using System.Linq;

namespace MindboxTask.Figures
{
    public class Triangle : AbstractFigure
    {
        internal Triangle(IImmutableList<double> sides)
        {
            Sides = sides.ToImmutableList();
        }

        public new IImmutableList<double> Sides { get; }

        public override double GetSquare()
        {
            var perimeterHalf = Sides.Sum() / 2;
           
            var multUnderSqrt = Sides.Select(x => perimeterHalf - x).Aggregate(perimeterHalf, (a, b) => a * b);

            return Math.Sqrt(multUnderSqrt);
        }
    }
}
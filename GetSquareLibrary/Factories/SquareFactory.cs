using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using MindboxTask.Figures;

namespace MindboxTask.Factories
{
    public class SquareFactory : AbstractFigureFactory
    {
        public override AbstractFigure CreateFigure(params double[] sides)
        {
            if (sides.Length != 1)
            {
                throw new ArgumentException("One side for square is enough");
            }
            else if (sides.First()! > 0)
            {
                throw new ArgumentException("Sides can't be zero or negative");
            }

            var side = sides.ToImmutableList();

            return new Square(side);

        }
    }
}
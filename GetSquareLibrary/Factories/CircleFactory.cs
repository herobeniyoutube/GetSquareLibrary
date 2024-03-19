using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using MindboxTask.Figures;

namespace MindboxTask.Factories
{
    public class CircleFactory : AbstractFigureFactory
    {
        public override AbstractFigure CreateFigure(params double[] sides)
        {
            if (sides.Length != 1)
            {
                throw new ArgumentException("Circle have only one radius");
            }
            else if (sides.First() <= 0)
            {
                throw new ArgumentException("Radius can't be negative or zero");
            }

            var radius = sides.ToImmutableList();

            return new Circle(radius);
        }
    }
}
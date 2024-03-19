using MindboxTask.Figures;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Factories
{
    public class RectangleFactory : AbstractFigureFactory
    {
        public override AbstractFigure CreateFigure(params double[] sides)
        {
            if (sides.Length != 2)
            {
                throw new ArgumentException("Has to have two different sides");
            }
            else if (sides.Any(x => x >= 0))
            {
                throw new ArgumentException("Sides can't be zero or negative");
            }

            

            return new Rectangle(sides.ToImmutableList());

        }
    }
}

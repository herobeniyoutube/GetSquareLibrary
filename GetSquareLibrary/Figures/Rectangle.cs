using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Figures
{
    public class Rectangle : AbstractFigure
    {
        internal Rectangle(IImmutableList<double> sides)
        {
            Sides = sides;
        }
        public new IImmutableList<double> Sides { get; }

        public override double GetSquare()
        {
            return Sides.Aggregate((x, y) => x * y);
        }
    }
}

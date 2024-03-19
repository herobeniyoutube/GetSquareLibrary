using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Figures
{
    public class Ellipse : AbstractFigure
    {
        internal Ellipse(IImmutableList<double> sides)
        {
            Semiaxes = sides;
        }

        public IImmutableList<double> Semiaxes { get; }

        public override double GetSquare()
        {
            return Math.PI * Semiaxes.Aggregate((x, y) => x * y);
        }
    }
}

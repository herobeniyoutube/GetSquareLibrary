using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Figures
{
    public abstract class AbstractFigure : IFigure
    {
        public IImmutableList<double> Sides { get; }
        public abstract double GetSquare();
    }
}

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Figures
{
    public interface IFigure
    {
        IImmutableList<double> Sides { get; }
        public abstract double GetSquare();
    }
}

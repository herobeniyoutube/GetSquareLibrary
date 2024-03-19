using MindboxTask.Figures;
using System.Collections.Generic;

namespace MindboxTask.Factories
{
    public abstract class AbstractFigureFactory
    {
        public abstract AbstractFigure CreateFigure(params double[] sides);
    }
}
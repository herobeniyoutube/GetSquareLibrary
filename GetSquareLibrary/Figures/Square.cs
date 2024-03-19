using MindboxTask.Figures;
using System;
using System.Collections.Immutable;
using System.Linq;

public class Square : AbstractFigure
{
    internal Square(IImmutableList<double> sides) 
    {
        Side = sides.First();
    }
    public double Side { get; }

    public override double GetSquare()
    {
        return Math.Sqrt(Side);
    }
}
using MindboxTask.Figures;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTask.Factories
{
    public class EllipseFactory : AbstractFigureFactory
    {
        public override AbstractFigure CreateFigure(params double[] sides)
        {
            if (sides.Length != 2)
            {
                throw new ArgumentException("Ellipse has two semiaxis");
            }
            else if (sides.Any(x => x <= 0))
            {
                throw new ArgumentException("Semiaxis can't be negative or zero");
            }
            else if (sides.First() == sides.Last())
            {
                Console.WriteLine("It's the circle");

                return new Circle(sides.ToImmutableList());
            }
            

            return new Ellipse(sides.ToImmutableList());
        }
    }
}

using DesignPatterns.Class.Composite.Draw;
using DesignPatterns.Class.Composite.Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Visitor
{
    public class FigureVisitorForWinForm : IFigureVisitor
    {
        public void Visit(Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public void Visit(Circle circle)
        {
            throw new NotImplementedException();
        }

        public void Visit(Triangle triangle)
        {
            throw new NotImplementedException();
        }

        public void Visit(FigureS figureS)
        {
            throw new NotImplementedException();
        }
    }
}

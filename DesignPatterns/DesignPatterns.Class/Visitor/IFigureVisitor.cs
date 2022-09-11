using DesignPatterns.Class.Composite.Draw;
using DesignPatterns.Class.Composite.Draw.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Visitor
{
    public interface IFigureVisitor
    {
        public void Visit(Rectangle rectangle);
        public void Visit(Circle circle);
        public void Visit(Triangle triangle);
        public void Visit(FigureS figureS);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Composite.Draw
{
    public class FigureS : Figure
    {
        public List<Figure> Figures { get; set; }

        public override void Drawing()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Composite.Draw.Figures
{
    public class Circle : Figure
    {
        private double ray;

        public Circle(double ray)
        {
            this.ray = ray;
        }

        public override void Drawing()
        {
            throw new NotImplementedException();
        }
    }
}

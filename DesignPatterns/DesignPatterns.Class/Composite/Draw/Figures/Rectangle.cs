using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Composite.Draw.Figures
{
    public class Rectangle : Figure
    {
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public override void Drawing()
        {
            throw new NotImplementedException();
        }
    }
}

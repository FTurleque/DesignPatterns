using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Composite.Draw
{
    public abstract class Figure
    {
        private int x;
        private int y;

        public abstract void Drawing();
    }
}

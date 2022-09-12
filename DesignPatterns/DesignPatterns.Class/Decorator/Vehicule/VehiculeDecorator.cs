using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Decorator.Vehicule
{
    public abstract class VehiculeDecorator : IVehiculePart
    {
        private IVehiculePart elementToDecorate;
        private decimal price;

        protected VehiculeDecorator(IVehiculePart _elementToDecorate, decimal _price)
        {
            this.elementToDecorate = _elementToDecorate;
            this.price = _price;
        }

        public abstract decimal DeterminatePrice();
    }
}

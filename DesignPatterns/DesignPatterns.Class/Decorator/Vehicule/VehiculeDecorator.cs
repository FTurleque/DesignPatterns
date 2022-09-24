using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Decorator.Vehicule
{
    public abstract class VehiculeDecorator : IVehiculePart
    {
        protected IVehiculePart elementToDecorate;
        public decimal Price { get; protected set; }

        protected VehiculeDecorator(IVehiculePart _elementToDecorate, decimal _price)
        {
            this.elementToDecorate = _elementToDecorate;
            this.Price = _price;
        }

        public abstract decimal DeterminatePrice();
    }
}

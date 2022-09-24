using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Decorator.Vehicule.Types
{
    public class Car : IVehiculePart
    {
        public decimal Price { get; private set; }

        public Car(decimal _price)
        {
            Price = _price;
        }

        public decimal DeterminatePrice()
        {
            return Price;
        }
    }
}

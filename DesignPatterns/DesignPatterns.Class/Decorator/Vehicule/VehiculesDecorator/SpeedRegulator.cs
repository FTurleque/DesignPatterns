﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Decorator.Vehicule.VehiculesDecorator
{
    public class SpeedRegulator : Sunroof
    {
        public SpeedRegulator(IVehiculePart _elementToDecorate, decimal _price) : base(_elementToDecorate, _price)
        {
        }

        public override decimal DeterminatePrice()
        {
            return Price + elementToDecorate.DeterminatePrice();
        }
    }
}

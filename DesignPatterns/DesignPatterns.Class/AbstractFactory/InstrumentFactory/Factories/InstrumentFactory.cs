﻿using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public interface InstrumentFactory
    {
        Instrument Instrument { get; set; }

        public Instrument CreateInstrument();
    }
}

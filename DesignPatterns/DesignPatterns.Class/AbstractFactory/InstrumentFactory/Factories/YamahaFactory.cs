﻿using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class YamahaFactory : InstrumentFactory
    {
        public Instrument Instrument { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Instrument CreateInstrument()
        {
            throw new NotImplementedException();
        }
    }
}

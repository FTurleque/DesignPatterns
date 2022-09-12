﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public class Synthesizer : KeyboardInstrument
    {
        public Synthesizer(string _name, string _model, string _type, int _price, int _numberOfKeys) : base(_name, _model, _type, _price, _numberOfKeys)
        {
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public class Piano : KeyboardInstrument
    {
        public Piano(string _model, string _type, int _price, int _numberOfKeys) : base(_model, _type, _price, _numberOfKeys)
        {
        }

        public override string ToString()
        {
            return "Piano";
        }
    }
}

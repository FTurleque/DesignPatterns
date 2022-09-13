﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public class Bass : StringedInstrument
    {
        public Bass(string _model, string _type, int _price, int _stringsNumber) : base(_model, _type, _price, _stringsNumber)
        {
        }
    }
}

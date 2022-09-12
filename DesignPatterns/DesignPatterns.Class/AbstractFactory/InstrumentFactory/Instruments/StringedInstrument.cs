using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public abstract class StringedInstrument : Instrument
    {
        private int stringsNumber;

        protected StringedInstrument(string _name, string _model, string _type, int _price, int _stringsNumber) : base(_name, _model, _type, _price)
        {
            this.stringsNumber = _stringsNumber;
        }
    }
}

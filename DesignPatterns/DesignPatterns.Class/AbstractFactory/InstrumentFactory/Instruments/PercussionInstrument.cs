using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public abstract class PercussionInstrument : Instrument
    {
        private int elementNumber;

        protected PercussionInstrument(string _name, string _model, string _type, int _price, int _elementNumber) : base(_name, _model, _type, _price)
        {
            this.elementNumber = _elementNumber;
        }
    }
}

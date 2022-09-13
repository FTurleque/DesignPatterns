using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public abstract class KeyboardInstrument : Instrument
    {
        private int numberOfKeys;

        protected KeyboardInstrument(string _name, string _model, string _type, int _price, int _numberOfKeys) : base(_name, _model, _type, _price)
        {
            this.numberOfKeys = _numberOfKeys;
        }

        public int NumberOfKeys
        {
            get { return numberOfKeys; }
            protected set { numberOfKeys = value; }
        }
    }
}

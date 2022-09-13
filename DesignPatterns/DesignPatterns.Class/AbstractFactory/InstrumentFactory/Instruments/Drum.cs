using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public class Drum : PercussionInstrument
    {
        public Drum(string _model, string _type, int _price, int _elementNumber) : base(_model, _type, _price, _elementNumber)
        {
        }
    }
}

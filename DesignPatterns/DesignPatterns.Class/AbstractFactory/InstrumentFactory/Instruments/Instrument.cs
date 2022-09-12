using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments
{
    public abstract class Instrument
    {
        private string name;
        private string model;
        private string type;
        private int price;

        protected Instrument(string _name, string _model, string _type, int _price)
        {
            this.name = _name;
            this.model = _model;
            this.type = _type;
            this.price = _price;
        }
    }
}

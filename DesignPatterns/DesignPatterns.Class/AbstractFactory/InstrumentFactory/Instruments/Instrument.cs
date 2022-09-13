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

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }

        public string Model
        {
            get { return this.model; }
            protected set { this.model = value; }
        }

        public string Type
        {
            get { return this.type; }
            protected set { this.type = value; }
        }

        public int Price
        {
            get { return this.price; }
            protected set { this.price = value; }
        }
    }
}

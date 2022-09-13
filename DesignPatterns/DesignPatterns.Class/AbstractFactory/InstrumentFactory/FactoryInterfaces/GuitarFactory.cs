using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface GuitarFactory
    {
        Instrument Instrument { get; set; }

        public Guitar CreateGuitar(string name);
    }
}

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IGuitarFactory
    {
        public Instrument CreateGuitar(string name);
    }
}

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IDrumFactory
    {
        public Instrument CreateDrum(string name);
    }
}

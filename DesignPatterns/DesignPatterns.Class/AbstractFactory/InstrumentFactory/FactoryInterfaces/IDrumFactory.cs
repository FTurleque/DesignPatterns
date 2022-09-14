using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IDrumFactory
    {
        Instrument InstrumentCreate { get; set; }

        public Instrument CreateDrum(string name);
    }
}

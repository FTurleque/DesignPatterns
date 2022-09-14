using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IGuitarFactory
    {
        Instrument InstrumentCreate { get; set; }

        public Instrument CreateGuitar(string name);
    }
}

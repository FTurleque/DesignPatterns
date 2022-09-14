using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IPianoFactory
    {
        Instrument InstrumentCreate { get; set; }

        public Instrument CreatePiano(string name);
    }
}

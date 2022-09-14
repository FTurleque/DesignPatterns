using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface IPianoFactory
    {
        public Instrument CreatePiano(string name);
    }
}

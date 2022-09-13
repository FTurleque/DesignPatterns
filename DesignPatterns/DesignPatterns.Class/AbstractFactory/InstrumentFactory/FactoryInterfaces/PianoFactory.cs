using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface PianoFactory
    {
        Instrument Instrument { get; set; }

        public Piano CreatePiano(string name);
    }
}

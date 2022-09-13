using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface DrumFactory
    {
        Instrument Instrument { get; set; }

        public Drum CreateDrum(string name);
    }
}

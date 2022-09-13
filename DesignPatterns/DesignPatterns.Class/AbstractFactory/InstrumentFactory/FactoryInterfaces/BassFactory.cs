using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface BassFactory
    {
        Instrument Instrument { get; set; }

        public Bass CreateBass(string name);
    }
}

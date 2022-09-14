using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface ISynthesizerFactory
    {
        Instrument InstrumentCreate { get; set; }

        public Instrument CreateSynthesizer(string name);
    }
}

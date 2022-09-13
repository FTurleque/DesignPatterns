using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces
{
    internal interface SynthesizerFactory
    {
        Instrument Instrument { get; set; }

        public Synthesizer CreateSynthesizer(string name);
    }
}

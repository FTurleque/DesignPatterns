using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class YamahaFactory : SynthesizerFactory, PianoFactory, GuitarFactory, BassFactory, DrumFactory
    {
        public Instrument Instrument { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Bass CreateBass(string name)
        {
            throw new NotImplementedException();
        }

        public Drum CreateDrum(string name)
        {
            throw new NotImplementedException();
        }

        public Guitar CreateGuitar(string name)
        {
            throw new NotImplementedException();
        }

        public Piano CreatePiano(string name)
        {
            throw new NotImplementedException();
        }

        public Synthesizer CreateSynthesizer(string name)
        {
            throw new NotImplementedException();
        }
    }
}

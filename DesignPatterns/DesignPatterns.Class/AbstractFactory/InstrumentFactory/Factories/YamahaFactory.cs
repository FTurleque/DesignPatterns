using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class YamahaFactory : ISynthesizerFactory, IPianoFactory, IGuitarFactory, IBassFactory, IDrumFactory
    {
        Dictionary<string, Instrument> catalogYamaha = InstrumentObject.GetcatalogYamaha;

        public Instrument InstrumentCreate { get; set; }

        public Instrument CreateBass(string name)
        {
            InstrumentCreate = catalogYamaha[name];
            return InstrumentCreate;
        }

        public Instrument CreateDrum(string name)
        {
            throw new NotImplementedException();
        }

        public Instrument CreateGuitar(string name)
        {
            throw new NotImplementedException();
        }

        public Instrument CreatePiano(string name)
        {
            throw new NotImplementedException();
        }

        public Instrument CreateSynthesizer(string name)
        {
            throw new NotImplementedException();
        }
    }
}

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class GibsonFactory : IGuitarFactory, IBassFactory
    {
        Dictionary<string, Instrument> catalogGibson = InstrumentObject.GetcatalogGibson;

        public Instrument InstrumentCreate { get; set; }

        public Instrument CreateBass(string name)
        {
            throw new NotImplementedException();
        }

        public Instrument CreateGuitar(string name)
        {
            throw new NotImplementedException();
        }
    }
}

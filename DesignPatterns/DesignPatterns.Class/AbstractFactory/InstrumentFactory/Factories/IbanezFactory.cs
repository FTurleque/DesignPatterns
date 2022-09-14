using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class IbanezFactory : IGuitarFactory, IBassFactory
    {
        Dictionary<string, Instrument> catalogIbanez = InstrumentObject.GetCatalogIbanez;

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

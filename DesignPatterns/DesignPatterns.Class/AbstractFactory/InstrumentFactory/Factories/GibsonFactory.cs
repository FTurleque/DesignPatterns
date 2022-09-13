using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class GibsonFactory : GuitarFactory, BassFactory
    {
        public Instrument Instrument { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Bass CreateBass(string name)
        {
            throw new NotImplementedException();
        }

        public Guitar CreateGuitar(string name)
        {
            throw new NotImplementedException();
        }
    }
}

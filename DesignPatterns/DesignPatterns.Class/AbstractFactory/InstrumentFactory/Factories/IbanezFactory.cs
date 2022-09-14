using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class IbanezFactory : IGuitarFactory, IBassFactory
    {
        Dictionary<string, Instrument> catalogIbanez = InstrumentObject.GetCatalogIbanez;

        /// <summary>
        /// Création d'une Basse.
        /// </summary>
        /// <param name="name">Model de la basse</param>
        /// <returns>retourne une basse ou null</returns>
        public Instrument CreateBass(string name)
        {
            return GetInstrument(name);
        }

        /// <summary>
        /// Création d'une Guitare.
        /// </summary>
        /// <param name="name">Model de la guitare</param>
        /// <returns>retourne une guitare ou null</returns>
        public Instrument CreateGuitar(string name)
        {
            return GetInstrument(name);
        }

        /// <summary>
        /// Recupération d'un Instrument.
        /// </summary>
        /// <param name="name">Model de l'instrument</param>
        /// <returns>retourne un instrument ou null</returns>
        private Instrument GetInstrument(string name)
        {
            if (catalogIbanez.ContainsKey(name))
            {
                return catalogIbanez[name];
            }
            else
            {
                throw new ArgumentNullException($"le model {name} n'existe pas dans le catalog");
            }
        }
    }
}

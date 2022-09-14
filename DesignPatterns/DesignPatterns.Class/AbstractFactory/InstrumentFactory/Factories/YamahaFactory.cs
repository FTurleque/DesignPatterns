using DesignPatterns.Class.AbstractFactory.InstrumentFactory.FactoryInterfaces;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories
{
    public class YamahaFactory : ISynthesizerFactory, IPianoFactory, IGuitarFactory, IBassFactory, IDrumFactory
    {
        Dictionary<string, Instrument> catalogYamaha = InstrumentObject.GetcatalogYamaha;

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
        /// Création d'une Batterie.
        /// </summary>
        /// <param name="name">Model de la batterie</param>
        /// <returns>retourne une batterie ou null</returns>
        public Instrument CreateDrum(string name)
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
        /// Création d'une Piano.
        /// </summary>
        /// <param name="name">Model de la piano</param>
        /// <returns>retourne un piano ou null</returns>
        public Instrument CreatePiano(string name)
        {
            return GetInstrument(name);
        }

        /// <summary>
        /// Création d'une Synthesizer.
        /// </summary>
        /// <param name="name">Model de la synthesizer</param>
        /// <returns>retourne un synthesizer ou null</returns>
        public Instrument CreateSynthesizer(string name)
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
            if (catalogYamaha.ContainsKey(name))
            {
                return catalogYamaha[name];
            }
            else
            {
                throw new ArgumentNullException($"le model {name} n'existe pas dans le catalog");
            }
        }
    }
}

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.AbstractFactory.InstrumentFactory.Objects
{
    public static class InstrumentObject
    {
        private static Dictionary<string, Instrument> catalogIbanez;

        private static Dictionary<string, Instrument> catalogGibson;

        private static Dictionary<string, Instrument> catalogYamaha;

        public static Dictionary<string, Instrument> GetCatalogIbanez 
        { 
            get 
            { 
                return new Dictionary<string, Instrument>()
                {
                    { "LGB300", new Guitar("LGB300", "Electro-Accoustique", 3499, 6) },
                    { "RG8570Z", new Guitar("RG8570Z", "Electrique", 2899, 6) },
                    { "AM2000H", new Guitar("AM2000H", "Electro-Accoustique", 2499, 6) },
                    { "JGM5", new Guitar("JGM5", "Accoustique", 1499, 6) },
                    { "AE295", new Guitar("AE295", "Accoustique", 521, 6) },
                    { "SR2600", new Bass("SR2600", "Electrique", 1549, 4) },
                    { "SR4FMDX", new Bass("SR4FMDX", "Electrique", 1444, 4) }
                }; 
            } 
        }
        public static Dictionary<string, Instrument> GetcatalogGibson 
        { 
            get 
            { 
                return new Dictionary<string, Instrument>()
                {
                    { "LP57", new Guitar("LP57", "Electrique", 6885, 6) },
                    { "SG", new Guitar("SG", "Electrique", 5333, 6) },
                    { "ES-335", new Guitar("ES-335", "Electro-Accoustique", 5777, 6) },
                    { "Hummingbird", new Guitar("Hummingbird", "Accoustique", 3769, 6) },
                    { "G200", new Guitar("G200", "Accoustique", 1985, 6) },
                    { "Thunderbird", new Bass("Thunderbird", "Electrique", 2790, 4) },
                    { "SG", new Bass("SG", "Electrique", 1490, 4) },
                    { "Thunderbird", new Bass("Thunderbird", "Electrique", 1845, 4) },
                }; 
            } 
        }
        public static Dictionary<string, Instrument> GetcatalogYamaha 
        { 
            get 
            { 
                return new Dictionary<string, Instrument>()
                {
                    { "SLG200S", new Guitar("SLG200S", "Electro-Accoustique", 789, 6) },
                    { "APX-T2", new Guitar("APX-T2", "Accoustique", 249, 6) },
                    { "APX-600", new Guitar("APX-600", "Accoustique", 339, 6) },
                    { "TRBX-304", new Bass("TRBX-304", "Electrique", 419, 4) },
                    { "TRBX-504", new Bass("TRBX-504", "Electrique", 569, 4) },
                    { "Burgundy", new Drum("Burgundy", "Accoustique", 749, 8) },
                    { "Stage", new Drum("Stage", "Accoustique", 1198, 10) },
                    { "DTX6K2", new Drum("DTX6K2", "Electrique", 1598, 8) },
                    { "DTX10K", new Drum("DTX10K", "Electrique", 4275, 9) },
                    { "YDP-145", new Piano("YDP-145", "Numérique", 899, 88) },
                    { "YDP-165", new Piano("YDP-165", "Numérique", 1249, 88) },
                    { "PSR-E373", new Synthesizer("PSR-E373", "Arrangeur", 219, 61) },
                    { "PSR-SX700", new Synthesizer("PSR-SX700", "Arrangeur", 1190, 61) },
                }; 
            } 
        }
    }
}

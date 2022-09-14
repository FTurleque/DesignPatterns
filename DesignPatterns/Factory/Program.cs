// See https://aka.ms/new-console-template for more information

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

List<string> ibanez = new List<string>()
{
    "LGB300", 
    "RG8570Z", 
    "AM2000H", 
    "JGM5", 
    "AE295", 
    "SR2600", 
    "SR4FMDX", 
};
/*IbanezFactory ibanezFactory = new IbanezFactory();
ibanezFactory.CreateBass(ibanez[0]);*/

List<string> gibson = new List<string>()
{
    "LP57", 
    "SG", 
    "ES-335", 
    "Hummingbird", 
    "G200", 
    "Thunderbird", 
    "SG", 
    "Thunderbird", 
};

List<string> yamaha = new List<string>()
{
    "SLG200S", 
    "APX-T2", 
    "APX-600", 
    "TRBX-304", 
    "TRBX-504", 
    "Burgundy", 
    "Stage", 
    "DTX6K2", 
    "DTX10K", 
    "DTX10K", 
    "YDP-165", 
    "PSR-E373", 
    "PSR-SX700", 
};

YamahaFactory yamahaFactory = new YamahaFactory();
yamahaFactory.CreateBass(yamaha[3]);


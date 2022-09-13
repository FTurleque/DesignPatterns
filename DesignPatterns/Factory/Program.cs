// See https://aka.ms/new-console-template for more information

using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Factories;
using DesignPatterns.Class.AbstractFactory.InstrumentFactory.Instruments;

IbanezFactory ibanez = new();

Instrument gt = ibanez.CreateInstrument(new Guitar("RG", "205ZR", "Electric", 500, 6));
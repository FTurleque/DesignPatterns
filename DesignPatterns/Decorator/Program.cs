// See https://aka.ms/new-console-template for more information
using DesignPatterns.Class.Decorator.Vehicule;
using DesignPatterns.Class.Decorator.Vehicule.Types;
using DesignPatterns.Class.Decorator.Vehicule.VehiculesDecorator;

Console.WriteLine("Hello, World!");

IVehiculePart myCar = new Car(150000);
myCar = new SpeedRegulator(myCar, 500);
myCar = new Sunroof(myCar, 1500);

Console.WriteLine(myCar.DeterminatePrice());
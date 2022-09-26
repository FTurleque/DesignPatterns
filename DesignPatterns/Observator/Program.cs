// See https://aka.ms/new-console-template for more information
using DesignPatterns.Class.Observator.Weather.Observers;
using DesignPatterns.Class.Observator.Weather.Subjects;

Weather weather = new Weather(20);
Person person1 = new Person("Fab", "Tutu", "Fafa@tata.com");
Person person2 = new Person("Zaza", "Matin", "Ququ316@toto.fr");

weather.AddObserver(person1);
weather.AddObserver(person2);

Thread Thread = new Thread(() =>
{
	{
		for (int i = 20; i >= 0; i--)
		{
			Thread.Sleep(3000);
			var t = weather.GetWeatherConditions(i);
			Console.WriteLine("\n" + i);
			Console.WriteLine("\n__________________________________________________________________________________________");
        }
	}
});

Thread.Start();

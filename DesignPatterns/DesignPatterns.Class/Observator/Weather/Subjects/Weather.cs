using DesignPatterns.Class.Observator.Weather.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Subjects
{
    public class Weather : NaturalSubject
    {
        public TheWeatherConditions CurrentWeatherConditions { get; private set; }

        public int Temperature { get; private set; }

        public Weather(int _temperature) : base()
        {
            CurrentWeatherConditions = GetWeatherConditions(_temperature);
            this.Temperature = _temperature;
        }

        public TheWeatherConditions GetWeatherConditions(int _temperature)
        {
            if (_temperature == 5)
            {
                GetStormy();
            }
            else if (_temperature == 10)
            {
                GetRainy();
            }
            else if (_temperature == 15)
            {
                GetCloudy();
            }
            else if (_temperature == 20)
            {
                GetBeautifull();
            }
            return this.CurrentWeatherConditions;
        }

        public void GetCloudy()
        {
            this.CurrentWeatherConditions = TheWeatherConditions.CLOUDY;
            Notify();
        }

        public void GetRainy()
        {
            this.CurrentWeatherConditions = TheWeatherConditions.RAINY;
            Notify();
        }

        public void GetStormy()
        {
            this.CurrentWeatherConditions = TheWeatherConditions.STORMY;
            Notify();
        }

        public void GetBeautifull()
        {
            this.CurrentWeatherConditions = TheWeatherConditions.BEAUTIFUL;
            Notify(); ;
        }
    }
}

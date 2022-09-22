using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Subjects
{
    public class Weather : NaturalSubject
    {
        private decimal temperature;

        public TheWeatherConditions TheWeatherConditions { get; set; }

        private decimal Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public void GetCloudy()
        {

        }

        public void GetRainy()
        {

        }

        public void GetStormy()
        {

        }

        public void GetBeautifull()
        {

        }
    }
}

using DesignPatterns.Class.Observator.Weather.Interfaces;
using DesignPatterns.Class.Observator.Weather.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Observers
{
    public class Person : INaturalObserver
    {
        public void Update(NaturalSubject _weather)
        {
            throw new NotImplementedException();
        }
    }
}

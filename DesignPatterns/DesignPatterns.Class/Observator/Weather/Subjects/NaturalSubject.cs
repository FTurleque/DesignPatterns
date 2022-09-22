using DesignPatterns.Class.Observator.Weather.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Subjects
{
    public class NaturalSubject : INaturalSubject
    {
        public INaturalObserver INaturalObserver
        {
            get => default;
            set
            {
            }
        }

        public void AddObserver(INaturalObserver _observer)
        {
            throw new NotImplementedException();
        }

        public void Notify()
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver(INaturalObserver _observer)
        {
            throw new NotImplementedException();
        }
    }
}

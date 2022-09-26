using DesignPatterns.Class.Observator.Weather.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Subjects
{
    public  class NaturalSubject : INaturalSubject
    {
        protected List<INaturalObserver> naturalObserverList;

        public string Warning { get; protected set; }

        public NaturalSubject()
        {
            this.naturalObserverList = new List<INaturalObserver>();
        }


        public void AddObserver(INaturalObserver _observer)
        {
            naturalObserverList.Add(_observer);
        }

        public void Notify()
        {
            foreach (INaturalObserver observer in naturalObserverList)
            {
                observer.Update(this);
            }
        }

        public void RemoveObserver(INaturalObserver _observer)
        {
            naturalObserverList.Remove(_observer);
        }
    }
}

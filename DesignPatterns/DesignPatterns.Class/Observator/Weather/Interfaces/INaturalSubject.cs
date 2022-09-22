using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Interfaces
{
    public interface INaturalSubject
    {
        public void Notify();
        public void AddObserver(INaturalObserver _observer);
        public void RemoveObserver(INaturalObserver _observer);
    }
}

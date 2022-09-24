using DesignPatterns.Class.Observator.Weather.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Interfaces
{
    public interface INaturalObserver
    {
        public void Update(NaturalSubject _naturalSubject);
    }
}

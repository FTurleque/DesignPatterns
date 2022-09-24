using DesignPatterns.Class.Observator.Weather.Interfaces;
using DesignPatterns.Class.Observator.Weather.Subjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Observator.Weather.Observers
{
    public class Phone : INaturalObserver
    {
        private string phoneNumber;

        public Phone(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }

        public void Update(NaturalSubject _naturalSubject)
        {
            Console.WriteLine(phoneNumber + " " + _naturalSubject.Warning);
        }
    }
}

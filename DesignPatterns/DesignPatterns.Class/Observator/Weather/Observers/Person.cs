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
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public Person(string _firstName, string _lastName, string _email)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Email = _email;
        }

        public void Update(NaturalSubject _naturalSubject)
        {
            Console.WriteLine(Email + " " + _naturalSubject.Warning);
        }
    }
}

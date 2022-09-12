using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Class.Iterator.Party
{
    public class Party : IEnumerable<Guest>
    {
        private List<Guest> guests;

        public int Count { get { return guests.Count; } }

        public Guest this[int index]
        {
            get { return guests[index]; }
        }

        public IEnumerator<Guest> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new EnumeratorDefaultToGuestInParty();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Iterator
{
    public interface NoteIterator
    {
        Note CurrentNote { get; }

        Note GetNext();

        bool HasMore();
    }
}
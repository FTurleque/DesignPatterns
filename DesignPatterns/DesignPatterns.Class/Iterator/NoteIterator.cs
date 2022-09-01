using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Iterator
{
    public interface NoteIterator
    {
        Note Current { get; }

        Note GetNext();

        bool HasMore();
    }
}
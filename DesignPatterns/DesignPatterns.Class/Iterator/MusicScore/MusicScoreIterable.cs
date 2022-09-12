using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Iterator.MusicScore
{
    public interface MusicScoreIterable
    {
        NoteIterator CreateNoteIterator();
        NoteIterator CreateWhiteNoteIterator();
        NoteIterator CreateNoteIteratorExt(string searchPattern);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Iterator
{
    public class WhiteNoteIterator : NoteIterator
    {
        private MusicScore notes;
        private int currentPosition;

        public WhiteNoteIterator(MusicScore _notes)
        {
            this.notes = _notes;
            currentPosition = 0;
        }

        public Note Current { get; private set; }

        public Note GetNext()
        {
            return HasMore() ? notes[++currentPosition] : default;
        }

        public bool HasMore()
        {
            return currentPosition < notes.Count;
        }
    }
}
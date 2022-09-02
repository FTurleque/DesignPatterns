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
        private string searchPattern;

        public WhiteNoteIterator(MusicScore _notes, string _searchPattern)
        {
            this.notes = _notes;
            this.searchPattern = _searchPattern;
            currentPosition = 0;
        }

        public Note Current {
            get 
            {
                return notes[currentPosition].Duration == searchPattern ? notes[currentPosition] : null;
            }
        }

        public Note GetNext()
        {
            if (currentPosition + 1 < notes.Count && notes[currentPosition + 1].Duration == searchPattern)
            {
                return notes[++currentPosition];
            }
            else
            {
                ++currentPosition;
                return  default;
            }
        }

        public bool HasMore()
        {
            return currentPosition < notes.Count;
        }
    }
}
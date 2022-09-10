using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Class.Iterator
{
    public class NoteIteratorExt : NoteIterator
    {
        private MusicScore notes;
        private int currentPosition;
        private string searchPattern;

        public NoteIteratorExt(MusicScore notes, string searchPattern)
        {
            this.notes = notes;
            this.currentPosition = IfGetCurrentIsPossible(0); 
            this.searchPattern = searchPattern;
        }

        public Note CurrentNote
        {
            get
            {
                return notes[currentPosition];
            }
        }

        public Note GetNext()
        {
            if (!HasMore())
            {
                throw new ArgumentOutOfRangeException("Il n'y a plus de note.");
            }
            currentPosition = IfGetCurrentIsPossible(++currentPosition);
            return notes[currentPosition];
        }

        public bool HasMore()
        {
            return IfGetCurrentIsPossible(currentPosition) < notes.Count;
        }

        private int IfGetCurrentIsPossible(int i)
        {
            while (currentPosition < notes.Count)
            {
                if (notes[i] == null || notes[i].Duration == searchPattern)
                {
                    return i;
                }
                i++;
            }
            return i;
        }
    }
}
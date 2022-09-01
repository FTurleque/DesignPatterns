namespace DesignPatterns.Class.Iterator
{
    public class NoteScoreIterator : NoteIterator
    {
        private MusicScore notes;
        private int currentPosition;

        public NoteScoreIterator(MusicScore notes)
        {
            this.notes = notes;
            currentPosition = 0;
        }

        public Note Current => notes[currentPosition];

        /// <summary>
        /// Récupère la note suivante de la partition.
        /// </summary>
        /// <returns>Retourne une note</returns>
        public Note GetNext()
        {
            return HasMore() ? notes[++currentPosition] : default;
        }

        /// <summary>
        /// Vérifie si si il y a d'autre notes.
        /// </summary>
        /// <returns>S'il reste des note ou pas</returns>
        public bool HasMore()
        {
            return currentPosition < notes.Count;
        }
    }
}
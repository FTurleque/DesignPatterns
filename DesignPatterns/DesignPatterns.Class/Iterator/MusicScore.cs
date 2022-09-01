namespace DesignPatterns.Class.Iterator
{
    public class MusicScore : MusicScoreIterable
    {
        private List<Note> notes;

        // Ex.
        // Clé de Sol indique qu’une note placée sur la deuxième ligne est un Sol
        // Clé d'Ut (Do) .....
        // Clé de Fa .....
        public string Key { get; set; }

        public string Title { get; set; }

        public string Autor { get; set; }

        // Durée du morceau.
        public int Time { get; private set; }

        // Date de composition.
        public string Date { get; set; }

        // Vitesse du morceau en Bpm.
        public int Tempo { get; set; }

        public int Count { get => notes.Count; }

        public NoteIterator NoteIterator
        {
            get => CreateNoteIterator();
        }

        public Note this[int i]
        {
            get 
            {
                if (i < Count)
                {
                    return notes[i];
                }
                return null;
            }
            set => notes[i] = value;
        }

        public MusicScore(string _key, string _title, string _autor, int _tempo)
        {
            Key = _key;
            Title = _title;
            Autor = _autor;
            Date = DateTime.Now.ToShortDateString();
            Tempo = _tempo;
            notes = new List<Note>();
        }

        /// <summary>
        /// Supprimer une note sur la partition
        /// </summary>
        /// <param name="_note">Note de musique</param>
        public void RemoveNote(Note _note)
        {
            notes.Remove(_note);
        }

        /// <summary>
        /// Ajouter une note a la partition.
        /// </summary>
        /// <param name="_note">Note de musique</param>
        public void AddNote(Note _note)
        {
            notes.Add(_note);
        }

        /// <summary>
        /// Création de l'itérateur de note.
        /// </summary>
        /// <returns>Retourne une instance de notre itérateur</returns>
        public NoteIterator CreateNoteIterator()
        {
            return new NoteScoreIterator(this);
        }

        public NoteIterator CreateWhiteNoteIterator()
        {
            return new WhiteNoteIterator(this);
        }
    }
}
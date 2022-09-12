namespace DesignPatterns.Class.Iterator.MusicScore
{
    public class MusicScore : MusicScoreIterable
    {
        private List<Note> notes = new List<Note>();

        // Clé (de Sol indique qu’une note placée sur la deuxième ligne est un Sol)
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

        public Note this[int i]
        {
            get
            {
                if (i < Count)
                {
                    return notes[i];
                }
                return null;
                // TODO : Gérer le null exception.
                /*if (i > Count - 1)
                {
                    throw new ArgumentOutOfRangeException("Hors Limites");
                }
                return notes[i];*/
            }
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
        /// Création de l'itérateur de toute note.
        /// </summary>
        /// <returns>Retourne une instance de notre itérateur</returns>
        /// <exception cref="ArgumentNullException">La liste est vide.</exception>
        public NoteIterator CreateNoteIterator()
        {
            if (notes.Count == 0)
            {
                throw new ArgumentNullException("Il n'y a pas de note présente sur la partition.");
            }
            return new NoteScoreIterator(this);
        }

        /// <summary>
        /// Création de l'itérateur de notes blanches
        /// </summary>
        /// <returns>Retourne une instance de notre itérateur</returns>
        /// <exception cref="ArgumentNullException">La liste ne comporte pas la note</exception>
        public NoteIterator CreateWhiteNoteIterator()
        {
            if (new WhiteNoteIterator(this, "Blanche").CurrentNote == null)
            {
                throw new ArgumentNullException("La note n'est pas présente sur la partition.");
            }
            return new WhiteNoteIterator(this, "Blanche");
        }

        /// <summary>
        /// Création de l'itérateur de notes avec paramètre.
        /// </summary>
        /// <param name="searchPattern">Paramètre de recherche</param>
        /// <returns>Retourne une instance de notre itérateur</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public NoteIterator CreateNoteIteratorExt(string searchPattern)
        {
            if (new WhiteNoteIterator(this, searchPattern).CurrentNote == null)
            {
                throw new ArgumentNullException("La note n'est pas présente sur la partition.");
            }
            return new WhiteNoteIterator(this, searchPattern);
        }
    }
}
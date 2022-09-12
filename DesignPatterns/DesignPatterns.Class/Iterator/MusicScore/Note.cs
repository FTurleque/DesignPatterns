namespace DesignPatterns.Class.Iterator.MusicScore
{
    public class Note
    {
        // Nom de la fondamental de la note.
        public string Name { get; }

        // Noire, Ronde, Blanche, Croche, Double-croche, Triple-croche, Quadruple-croche
        public string Duration { get; }

        public Note(string _name, string _duration)
        {
            Name = _name;
            Duration = _duration;
        }
    }
}
namespace DesignPatterns.Class.Iterator
{
    public class Note
    {
        // Nom de la fondamental de la note.
        public string Name { get; }

        // Son de la note en Hz.
        public int Frequency { get; set; }

        // Durée de la note.
        public string Time { get; set; }

        // Placement sur la partition, hauteur de note.
        public int Pitch { get; }

        // Noire, Ronde, Blanche, Croche, Double-croche, Triple-croche, Quadruple-croche
        public string Duration { get; }

        // Dièse, Bémol, Bécarré, Double Dièse, Double Bémol
        public string Alteration { get; set; }

        // Accord.
        public string Chord { get; set; }

        public Note(string _name, string _duration)
        {
            Name = _name;
            Duration = _duration;
        }
    }
}
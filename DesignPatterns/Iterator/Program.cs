// See https://aka.ms/new-console-template for more information

using DesignPatterns.Class.Iterator;

Note nDo = new Note("Do", "Noire");
Note nRe = new Note("Re", "Croche");
Note nMi = new Note("Mi", "Double_Croche");
Note nFa = new Note("Fa", "Triple-Croche");
Note nSol = new Note("Sol", "Blanche");
Note nLa = new Note("La", "Ronde");
Note nSi = new Note("Si", "Noire");


MusicScore myScore = new MusicScore("Sol", "Perdu dans les bois", "Lola", 100);

myScore.AddNote(nDo);
myScore.AddNote(nRe);
myScore.AddNote(nMi);
myScore.AddNote(nFa);
myScore.AddNote(nSol);
myScore.AddNote(nLa);
myScore.AddNote(nSi);

NoteIterator scoreIterator = myScore.CreateNoteIterator();

while (scoreIterator.HasMore())
{
    Console.WriteLine(scoreIterator.Current.Name);
    scoreIterator.GetNext();
}


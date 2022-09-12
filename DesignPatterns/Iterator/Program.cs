// See https://aka.ms/new-console-template for more information

using DesignPatterns.Class.Iterator.MusicScore;

Note nDo = new Note("Do", "Noire");
Note nRe = new Note("Re", "Croche");
Note nMi = new Note("Mi", "Blanche");
Note nFa = new Note("Fa", "Triple-Croche");
Note nSol = new Note("Sol", "Double_Croche");
Note nLa = new Note("La", "Ronde");
Note nSi = new Note("Si", "Noire");


MusicScore myScore = new MusicScore("Sol", "Perdu dans les bois", "Lola", 100);

/*Au claire de la lune*/
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nRe);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
////////////////////////////////////////
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nRe);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
////////////////////////////////////////////
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nLa);
myScore.AddNote(nLa);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
myScore.AddNote(nSi);
myScore.AddNote(nLa);
myScore.AddNote(nDo);
///////////////////////////////////////////////
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nDo);
myScore.AddNote(nRe);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
myScore.AddNote(nMi);
myScore.AddNote(nRe);
myScore.AddNote(nRe);
myScore.AddNote(nDo);
/*myScore.AddNote(nFa);
myScore.AddNote(nSol);
myScore.AddNote(nLa);
myScore.AddNote(nSi);*/

NoteIterator scoreIterator = myScore.CreateNoteIterator();

Console.WriteLine("Itération de toutes les notes :\n");
while (scoreIterator.HasMore())
{
    Console.Write(scoreIterator.CurrentNote.Name + " ");
    scoreIterator.GetNext();
}

Console.WriteLine("\n===============================================================================\nItération de toutes les notes blanches\n");


try
{
    NoteIterator whiteNoteIterator = myScore.CreateWhiteNoteIterator();
    while (whiteNoteIterator.HasMore())
    {
        Console.WriteLine(whiteNoteIterator.CurrentNote.Name);
        whiteNoteIterator.GetNext();
    }
}
catch (ArgumentNullException e)
{
    Console.WriteLine(e.Message);
}
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

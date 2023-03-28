using System;
using System.Collections.Generic;
using System.Diagnostics;

class CreateFlashcardsCommand : Command
{
    
    public override void Execute()
    {
        CreateFlashcardFile newFlashcards = new CreateFlashcardFile();

        newFlashcards.SetSubject();

        newFlashcards.CreateFile();



    }





}
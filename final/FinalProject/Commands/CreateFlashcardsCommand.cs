using System;
using System.Collections.Generic;
using System.Diagnostics;

class CreateFlashcardsCommand : Command
{

    public override void Execute()
    {
        CreateFiles newFlashcards = new CreateFiles();

        newFlashcards.SetFolder("FlashcardFiles");

        newFlashcards.SetInstructions("Question|Answer");

        newFlashcards.SetSetType("studyset");

        newFlashcards.SetSubject();

        newFlashcards.CreateFile();

    }


}
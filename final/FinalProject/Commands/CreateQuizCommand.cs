using System;
using System.Collections.Generic;
using System.Diagnostics;

class CreateQuizCommand : Command
{
    
    public override void Execute()
    {
        CreateFiles newFlashcards = new CreateFiles();

        newFlashcards.SetFolder("QuizFiles");

        newFlashcards.SetInstructions("--DELETE INSTRUCTIONS BEFORE SAVING-- \n Question|Answer 1|Answer 2|Answer 3|Correct answer index (starting with 0)");

        newFlashcards.SetSetType("quiz");

        newFlashcards.SetSubject();

        newFlashcards.CreateFile();



    }





}
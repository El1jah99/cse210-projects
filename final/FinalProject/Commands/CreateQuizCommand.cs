using System;
using System.Collections.Generic;
using System.Diagnostics;

class CreateQuizCommand : Command
{
    
    public override void Execute()
    {
        CreateFiles newFlashcards = new CreateFiles();

        newFlashcards.SetFolder("QuizFiles");

        newFlashcards.SetInstructions("Question|Answer 1|Answer 2|Answer 3|Answer 4|Correct answer number (1-4)");

        newFlashcards.SetSetType("quiz");

        newFlashcards.SetSubject();

        newFlashcards.CreateFile();



    }





}
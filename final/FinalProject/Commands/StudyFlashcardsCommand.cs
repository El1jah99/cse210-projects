using System;
using System.Collections.Generic;

class StudyFlashcardsCommand : Command
{
    
    public override void Execute()
    {
        StudySession studysession = new StudyFlashcards();

        studysession.StartStudySession();
        studysession.EndStudySession();


    }





}
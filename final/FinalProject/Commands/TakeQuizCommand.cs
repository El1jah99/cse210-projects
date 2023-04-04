using System;
using System.Collections.Generic;

class TakeQuizCommand : Command
{

    public override void Execute()
    {
        StudySession studysession = new TakeQuiz();

        studysession.StartStudySession();
        studysession.EndStudySession();


    }





}
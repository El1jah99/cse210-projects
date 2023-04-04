using System;


class DeleteQuizzesCommand : Command
{

    public override void Execute()
    {
        string folder = "QuizFiles";
        ManageFiles.DeleteFile(folder);

    }


}
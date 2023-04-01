using System;


class DeleteFlashcardsCommand : Command
{
    
    public override void Execute()
    {
        ManageFiles.DeleteFile();

    }


}
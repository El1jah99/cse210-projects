using System;


class DeleteFlashcardsCommand : Command
{

    public override void Execute()
    {
        string folder = "FlashcardFiles";
        ManageFiles.DeleteFile(folder);

    }


}
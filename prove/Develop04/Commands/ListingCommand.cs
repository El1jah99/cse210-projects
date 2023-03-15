using System;

class ListingCommand : Command

{
    public override void Execute()
    {
        

        Activity activity = new ListingActivity();

        activity.DisplayWelcomeMessage();
        activity.StartActivity();
        activity.EndActivity();


    }


}
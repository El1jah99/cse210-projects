using System;

class ReflectionCommand : Command

{
    public override void Execute()
    {
        

        Activity activity = new ReflectionActivity();

        activity.DisplayWelcomeMessage();
        activity.StartActivity();
        activity.EndActivity();


    }




}
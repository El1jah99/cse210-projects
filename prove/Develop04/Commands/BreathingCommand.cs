using System;
using System.Collections.Generic;

class BreathingCommand : Command

{

    public override void Execute()
    {

        Activity activity = new BreathingActivity();

        activity.DisplayWelcomeMessage();
        activity.StartActivity();
        activity.EndActivity();

    }
    

}
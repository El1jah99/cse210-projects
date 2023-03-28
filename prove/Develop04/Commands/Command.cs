using System;


class Command

{
    public virtual void Execute()
        {
            
            throw new Exception("Sorry, that activity isn't available");
        }

}
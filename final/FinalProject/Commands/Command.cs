using System;


class Command

{
    public virtual void Execute()
    {

        throw new Exception("Method not implemented in base class");
    }

}
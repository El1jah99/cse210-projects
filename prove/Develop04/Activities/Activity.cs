using System;


public class Activity
{
    
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration;
    
    private Timer _timer = new Timer();

    
    public virtual void StartActivity()
    { 

    }

    public void EndActivity() 
    {

        Console.Clear();

        Console.WriteLine("Good Job!");
        _timer.BouncyBall(5);

        Console.WriteLine($"You spent {_activityDuration} seconds on the {_activityName}.");
        _timer.BouncyBall(5);

        Console.Clear();

    }


    public void DisplayWelcomeMessage()
    {

        Console.WriteLine($"Welcome to the {_activityName}.\n");

        _timer.Count(2);

        Console.WriteLine($"{_activityDescription}\n");

        _timer.Count(2);

        Console.WriteLine($"How many seconds would you like to spend on the {_activityName}?\n");
        _activityDuration = Int32.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Prepare yourself...");

        StartTimer().BouncyBall(8);

        Console.Clear();

    }

    public Timer StartTimer()
    {
        return _timer;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityName(string name)
    {
        _activityName = name;
    }

    public void SetActivityDescription(string description)
    {
        _activityDescription = description;
    }


}
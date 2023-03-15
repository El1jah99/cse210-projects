using System;

public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        SetActivityName("Breathing Activity");

        SetActivityDescription("This activity will help you focus on your breathing. Try to clear your mind and focus on taking deep breaths.");

    }

    public override void StartActivity()
    {
        StartBreathing();
    }

    private void StartBreathing()
    {

        int repetitions = (GetActivityDuration() / 10) + 1;
        for (int i = 0; i < repetitions; i++)
        {

            StartTimer().DisplayCountdown("Breathe in...", 6);
            StartTimer().DisplayCountdown("Breathe out... ", 4);

        }


    }







}
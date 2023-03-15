using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{

    public ListingActivity()
    {
        
        SetActivityName("Listing Activity");
        SetActivityDescription("In this activity, you will list as many of the positive things in your life as you can within the alloted time.");
    
    }


    private List<string> _listingPrompts = new List<string>(){
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
    
    private Random _random = new Random();


    public override void StartActivity()
    {
        
        DisplayListingPrompt();

        StartTimer().DisplayCountdown("Start in", 5);

        CountInputs();


    }

    private void DisplayListingPrompt()
    {
        
        Console.WriteLine("Respond to the following prompt with as many answers as you can think of:");
        Console.WriteLine($"{_listingPrompts[_random.Next(_listingPrompts.Count)]}\n");


    }

    private void CountInputs()
    {

         DateTime futureTime = StartTimer().GetFutureTime(GetActivityDuration());

            int i = 0;

            while (!StartTimer().CheckIfTimeHasPast(futureTime))
            {
                Console.Write("~ ");
                Console.ReadLine();

                i++;
            }

            StartTimer().DisplayAnimation($"You listed {i} items!", 5);
     
    }


}


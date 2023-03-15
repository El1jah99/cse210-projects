using System;

public class ReflectionActivity : Activity
{


    public ReflectionActivity()
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity is all about reflecting on key moments in your life and how they have made you who you are today.");

    }

    private List<string> _reflectionPrompts = new List<string>(){
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};

    private List<string> _reflectionQuestions = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"};

    private Random _random = new Random();

    public override void StartActivity()
    {

        DisplayReflectionPrompt();

        Console.WriteLine("Take some time to reflect on each of these question:");
            StartTimer().DisplayCountdown("Begin in", 5);
            
            DisplayReflectionQuestions();

    }

    private void DisplayReflectionPrompt()
    {

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"{_reflectionPrompts[_random.Next(_reflectionPrompts.Count)]}\n");
        Console.WriteLine("Once you have thought of an experience, press Enter.");
        Console.ReadLine();

    }

    private void DisplayReflectionQuestions()
    {

        int numQuestions = (GetActivityDuration() / 10) + 1;

        for (int i = 0; i < numQuestions; i++)
        {

            StartTimer().DisplayAnimation(_reflectionQuestions[_random.Next(_reflectionQuestions.Count)], 10);


        }

    }



}